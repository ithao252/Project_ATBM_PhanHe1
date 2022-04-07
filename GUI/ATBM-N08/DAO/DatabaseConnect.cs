using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;


namespace ATBM_N08.DAO
{
    public class DatabaseConnect
    {
        protected static OracleConnection _conn = null;
        public static void InitConnection(String username, String password)
        {
            String connectionString = $"Data Source=localhost/XE;User ID = {username}; Password={password}";
            
            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(connectionString);
                _conn = connection;
                _conn.Open();
                _conn.Close();
                dbaUsername = username;
            }
            catch (OracleException ex)
            {
                _conn = null;
                throw new Exception(ex.Message);
            }

        }
        protected static String dbaUsername;
        public String DBAUsername
        {
            get { return dbaUsername.ToUpper(); }
            set { dbaUsername = value; }
        }

    }
}
