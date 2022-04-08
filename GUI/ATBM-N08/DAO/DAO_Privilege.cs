﻿using System;
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

/*        public void RevokePrivilege(String table_name)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"DROP TABLE {table_name}";
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
*/
/*        public void CreateTable(String table_name)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"CREATE USER {username} IDENTIFIED BY {password}";
            command.Connection = _conn;

            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                command.CommandText = $"GRANT CONNECT TO {username}";
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
*/
        public DataTable GetAllPrivileges()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM role_sys_privs ORDER BY ROLE ASC";
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
