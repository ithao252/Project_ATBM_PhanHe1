using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using ATBM_N08.DTO;


namespace ATBM_N08.DAO
{
    public class DAO_Privilege : DatabaseConnect
    {
        private static DAO_Privilege _instance = null;
        public static DAO_Privilege Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_Privilege();
                }
                return _instance;
            }
        }

        public void GrantPrivilege(String user_role, String privs, bool admin_option)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT {privs} TO {user_role}";

            if (admin_option == true)
                command.CommandText += " WITH ADMIN OPTION";

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

        public void RevokePrivilege(String user_role, String privs)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE {privs} FROM {user_role}";
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


        public DataTable GetAllPrivileges()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM session_privs ORDER BY privilege";
            command.Connection = _conn;

            OracleDataAdapter adapter;
            DataTable dataTable;
            try
            {
                adapter = new OracleDataAdapter(command);
                dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }

        public DataTable GetRolePrivileges()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM role_sys_privs ORDER BY role";
            command.Connection = _conn;

            OracleDataAdapter adapter;
            DataTable dataTable;
            try
            {
                adapter = new OracleDataAdapter(command);
                dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }

        public DataTable GetUserPrivileges()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM user_sys_privs ORDER BY username";
            command.Connection = _conn;

            OracleDataAdapter adapter;
            DataTable dataTable;
            try
            {
                adapter = new OracleDataAdapter(command);
                dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }

        public DataTable FindRolePrivileges(String role)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM role_sys_privs " + 
                                    $"WHERE role = '{role}'";
            command.Connection = _conn;

            OracleDataAdapter adapter;
            DataTable dataTable;
            try
            {
                adapter = new OracleDataAdapter(command);
                dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }

        public DataTable FindUserPrivileges(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM user_sys_privs " +
                                    $"WHERE username = '{username}'";
            command.Connection = _conn;

            OracleDataAdapter adapter;
            DataTable dataTable;
            try
            {
                adapter = new OracleDataAdapter(command);
                dataTable = new DataTable(); //create a new table
                adapter.Fill(dataTable);
            }
            catch (OracleException ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }

    }

}
