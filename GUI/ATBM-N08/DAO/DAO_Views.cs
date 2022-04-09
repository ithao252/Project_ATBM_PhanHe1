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
    public class DAO_Views : DatabaseConnect
    {
        private static DAO_Views _instance = null;
        public static DAO_Views Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_Views();
                }
                return _instance;
            }
        }

        //        public void DeleteTable(String table_name)
        //        {
        //            OracleCommand command = new OracleCommand();
        //            command.CommandText = $"DROP TABLE {table_name}";
        //            command.Connection = _conn;

        //            try
        //            {
        //                _conn.Open();
        //                command.ExecuteNonQuery();
        //                _conn.Close();
        //            }
        //            catch (OracleException ex)
        //            {
        //                _conn.Close();
        //                throw new Exception(ex.Message);
        //            }

        //        }

        ///*        public void CreateTable(String table_name)
        //        {
        //            OracleCommand command = new OracleCommand();
        //            command.CommandText = $"CREATE USER {username} IDENTIFIED BY {password}";
        //            command.Connection = _conn;

        //            try
        //            {
        //                _conn.Open();
        //                command.ExecuteNonQuery();
        //                command.CommandText = $"GRANT CONNECT TO {username}";
        //                command.ExecuteNonQuery();
        //                command.CommandText = $"COMMIT";
        //                command.ExecuteNonQuery();
        //                _conn.Close();
        //            }
        //            catch (OracleException ex)
        //            {
        //                _conn.Close();
        //                throw new Exception(ex.Message);
        //            }
        //        }
        //*/
        public DataTable GetAllViews()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "select owner, view_name from all_views order by owner, view_name";
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

        public DataTable GetOwnerViews(String owner_view)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT owner, view_name FROM all_views " +
                                    $"WHERE owner = '{owner_view}'";
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


        //        public DataTable GetDetailTable(String table_name)
        //        {
        //            OracleCommand command = new OracleCommand();
        //            command.CommandText = "SELECT * FROM all_tab_columns " +
        //                                    $"WHERE table_name = '{table_name}'";
        //            command.Connection = _conn;

        //            OracleDataAdapter adapter;
        //            DataTable dataTable;
        //            try
        //            {
        //                adapter = new OracleDataAdapter(command);
        //                dataTable = new DataTable(); //create a new table
        //                adapter.Fill(dataTable);
        //            }
        //            catch (OracleException ex)
        //            {
        //                throw new Exception(ex.Message);
        //            }

        //            return dataTable;
        //        }
    }

}
