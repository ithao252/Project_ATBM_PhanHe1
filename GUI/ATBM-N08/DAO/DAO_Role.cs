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
    public class DAO_Role : DatabaseConnect
    {
        private static DAO_Role _instance = null;
        public static DAO_Role Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_Role();
                }
                return _instance;
            }
        }

        public void RevokeRoleFromUser(String user, String role)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"REVOKE {role} FROM {user}";
            command.Connection = _conn;

            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                command.CommandText = $"COMMIT";
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException ex)
            {
                _conn.Close();
                throw new Exception(ex.Message);
            }
        }

        public void GrantRoleToUser(String user, String role)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"GRANT {role} TO {user}"; 
            command.Connection = _conn;

            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                command.CommandText = $"COMMIT";
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException ex)
            {
                _conn.Close();
                throw new Exception(ex.Message);
            }
        }

        public void DeleteRole(String role)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"DROP ROLE {role}";
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


        public void UpdateRole(String role, String newpassword, int result)
        {
            OracleCommand command = new OracleCommand();
            if (result == 1)
            { command.CommandText = $"ALTER ROLE {role} NOT IDENTIFIED"; }
            else
            { command.CommandText = $"ALTER ROLE {role} IDENTIFIED BY {newpassword}"; }

            command.Connection = _conn;

            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                command.CommandText = $"COMMIT";
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException ex)
            {
                _conn.Close();
                throw new Exception(ex.Message);
            }
        }

        public void CreateRole(String role, String password, int result)
        {
            OracleCommand command = new OracleCommand();
            if (result == 1)
            { command.CommandText = $"CREATE ROLE {role}"; }
            else
            { command.CommandText = $"CREATE ROLE {role} IDENTIFIED BY {password}"; }
            
            command.Connection = _conn;

            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                command.CommandText = $"GRANT CONNECT TO {role}";
                command.ExecuteNonQuery();
                command.CommandText = $"COMMIT";
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException ex)
            {
                _conn.Close();
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetAllRoles()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "select * from sys.dba_roles order by ROLE";
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

        public DataTable GetRoleOfUser()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM DBA_ROLE_PRIVS ORDER BY GRANTEE";
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
