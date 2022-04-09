using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;


namespace ATBM_N08.DAO
{
    public class DAO_Privilege_Column: DatabaseConnect
    {
        private static DAO_Privilege_Column _instance = null;

        public static DAO_Privilege_Column Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_Privilege_Column();
                }
                return _instance;
            }
        }


        public DataTable GetPrivilegeOnColumnUpdateInsert(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE = '{username}'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }
        public void GrantPrivilegeUpdateOnColumn(String username, String table, String column, bool grantable)
        {
            String grantableStr = "";
            if (grantable)
            {
                grantableStr = "WITH GRANT OPTION";
            }

            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT UPDATE({column}) ON {table} TO {username} {grantableStr}";
            command.Connection = _conn;
            _conn.Open();
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public DataTable GetPrivilegeOnView(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{username}' AND TYPE = 'VIEW'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void RevokePrivilegeSelectOnColumn(String username, String table, String column)
        {
            try
            {
                OracleCommand command = new OracleCommand();
                command.CommandText = $"REVOKE SELECT ON {table + "_" + column + "_" + username + "_view"} FROM {username}";
                command.Connection = _conn;
                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                _conn.Close();
            }
        }

        public void RevokePrivilegeUpdateOnColumn(String username, String table, String column)
        {
            try
            {
                OracleCommand command = new OracleCommand();
                command.CommandText = $"REVOKE UPDATE ON {table} FROM {username}";
                command.Connection = _conn;
                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                _conn.Close();
            }
        }

        public void GrantPrivilegeSelectOnColumn(String username, String table, String column, bool grantable)
        {
            String grantableStr = "N";
            if (grantable)
            {
                grantableStr = "Y";
            }
            OracleCommand command = new OracleCommand("GRANT_SELECT_ON_COLUMN", _conn);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter param1 = new OracleParameter("Table_name", OracleDbType.Varchar2);
            param1.Value = table;
            OracleParameter param2 = new OracleParameter("user_name", OracleDbType.Varchar2);
            param2.Value = username;
            OracleParameter param3 = new OracleParameter("column_list", OracleDbType.Varchar2);
            param3.Value = column;
            OracleParameter param4 = new OracleParameter("grant_opt", OracleDbType.Char);
            param4.Value = grantableStr;

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            _conn.Open();
            command.ExecuteNonQuery();
            _conn.Close();

        }
    }
}
