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
            //String connectionString = $"Data Source=10.211.55.5/XEPDB1;User ID = {username}; Password={password}";
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

        public DataSet ExecuteQueryOracle(string query, string username, string pass)
        {
            try
            {
                String connectionString = $"Data Source=localhost/ORCL;User ID = {username}; Password={pass}";
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    OracleCommand getTableMetadataCmd;
                    getTableMetadataCmd = new OracleCommand(query, con);
                    con.Close();

                    OracleDataAdapter oda = new OracleDataAdapter(getTableMetadataCmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        return ds;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

    }
}
