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
    public class DAO_Table : DatabaseConnect
    {
        private static DAO_Table _instance = null;
        public static DAO_Table Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_Table();
                }
                return _instance;
            }
        }

        public void DeleteTable(String table_name)
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

        public void CreateTable(String query_create_table)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = query_create_table;
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

        public DataTable GetAllTables()
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM all_tables ORDER BY OWNER ASC";
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

        public DataTable GetOwnerTables(String owner_table)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM all_tables " +
                                    $"WHERE owner = '{owner_table}'";
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


        public DataTable GetDetailTable(String table_name)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM all_tab_columns " +
                                    $"WHERE table_name = '{table_name}'";
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
