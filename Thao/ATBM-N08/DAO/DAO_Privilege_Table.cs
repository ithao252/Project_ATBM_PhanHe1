using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;




namespace ATBM_N08.DAO
{
    public class DAO_Privilege_Table : DatabaseConnect
    {
        private static DAO_Privilege_Table _instance = null;

        public static DAO_Privilege_Table Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_Privilege_Table();
                }
                return _instance;
            }
        }

        public DataTable GetPrivilegeOnTable(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{username}' AND TYPE = 'TABLE' ORDER BY TABLE_NAME";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            adapter.Fill(dataTable);

            return dataTable;
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

        public void RevokeAllPrivilegesOnTable(String username, String table)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE ALL PRIVILEGES ON {table} FROM {username}";
            command.Connection = _conn;
            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException ex)
            {
                _conn.Close();
                throw new Exception(ex.Message);
            }
        }

        

        public void GrantPrivilegesOnTable(String username, String privileges, String table, bool grantable)
        {
            String grantableStr = "";
            if (grantable)
            {
                grantableStr = "WITH GRANT OPTION";
            }

            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT {privileges} ON {table} TO {username} {grantableStr}";
            command.Connection = _conn;
            _conn.Open();
            command.ExecuteNonQuery();
            _conn.Close();
        }

        

        



    }



}
