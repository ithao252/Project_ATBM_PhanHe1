using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM_N08.DAO;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_N08
{
    public partial class fNghienCuu : Form
    {

        private OracleConnection con = null;
        public string username = null;
        public string password = null;

        private void setConnection()
        {
            string connectionString = $"Data Source=localhost/XE;User ID = {username}; Password={password}";
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception exp)
            {
                con.Close();
            }
        }

        public fNghienCuu(string user, string pass)
        {
            username = user;
            password = pass;
            this.setConnection();
            InitializeComponent();
        }

        private void fNghienCuu_Load(object sender, EventArgs e)
        {
            dtgv_NghienCuu.EnableHeadersVisualStyles = false;
            dtgv_NghienCuu.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dtgv_NghienCuu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgv_NghienCuu.ColumnHeadersDefaultCellStyle.Font = new Font(dtgv_NghienCuu.Font, FontStyle.Bold);
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SET ROLE NGHIENCUU"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            try
            {
                int n = cmd.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fNghienCuu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
        }

        private DataTable LoadHSBA()
        {
            OracleCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM HSBA";

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

            /*
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from HSBA"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
            */
        }

        private DataTable LoadHSBA_DV()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from HSBA_DV"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private void btn_HSBA_Click(object sender, EventArgs e)
        {
            dtgv_NghienCuu.Columns.Clear();

            DataTable dt = LoadHSBA(); // Data table object
            dtgv_NghienCuu.DataSource = dt.DefaultView;
        }

        private void btn_HSBADV_Click(object sender, EventArgs e)
        {
            dtgv_NghienCuu.Columns.Clear();

            DataTable dt = LoadHSBA_DV(); // Data table object
            dtgv_NghienCuu.DataSource = dt.DefaultView;
        }
    }
}
