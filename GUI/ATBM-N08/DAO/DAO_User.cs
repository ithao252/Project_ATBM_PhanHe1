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
    public class DAO_User : DatabaseConnect
    {
        private static DAO_User _instance = null;
        public static DAO_User Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_User();
                }
                return _instance;
            }
        }


        public void DeleteUser(String username, bool cascade)
        {
            String cascadeStr = "";
            if (cascade)
            {
                cascadeStr = "CASCADE";
            }

            OracleCommand command = new OracleCommand();
            command.CommandText = $"DROP USER {username} {cascadeStr}";
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


        public void UpdateUser(String username, bool isLock, String password)
        {
            String lockStr = "";
            if (isLock)
            {
                lockStr = "LOCK";
            }
            else
            {
                lockStr = "UNLOCK";
            }

            OracleCommand command = new OracleCommand();
            command.CommandText = $"ALTER USER {username} IDENTIFIED BY {password.Trim().ToUpper()}";
            command.Connection = _conn;

            try
            {
                _conn.Open();
                command.ExecuteNonQuery();
                command.CommandText = $"ALTER USER {username} ACCOUNT {lockStr}";
                command.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException ex)
            {
                _conn.Close();
                throw new Exception(ex.Message);
            }
        }


        public void CreateUser(String username, String password)
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



        public DataTable GetAllUsers()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM all_users ORDER BY CREATED DESC";
            //command.CommandText = "select USER_ID, USERNAME, CREATED from all_users";
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
