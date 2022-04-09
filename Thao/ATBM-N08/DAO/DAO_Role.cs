using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace ATBM_N08.DAO
{
    public class DAO_Role: DatabaseConnect
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

        public DataTable GetRolesOfUser(String username)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText = $"SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '{username}'";
            command.Connection = _conn;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable(); //create a new table
            try
            {
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
