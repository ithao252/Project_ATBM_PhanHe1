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
    public partial class fThanhTra : Form
    {

        private OracleConnection con = null;
        public string username = null;
        public string password = null;

        private void setConnection()
        {
            string connectionString = $"Data Source=localhost/ORCL;User ID = {username}; Password={password}";
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

        public fThanhTra(string user, string pass)
        {
            username = user;
            password = pass;
            this.setConnection();
            InitializeComponent();
        }

        private void fThanhTra_Load(object sender, EventArgs e)
        {
            dtgv_ThanhTra.EnableHeadersVisualStyles = false;
            dtgv_ThanhTra.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dtgv_ThanhTra.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgv_ThanhTra.ColumnHeadersDefaultCellStyle.Font = new Font(dtgv_ThanhTra.Font, FontStyle.Bold);
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SET ROLE THANHTRA"; // Sql statement
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

        private void button1_Click(object sender, EventArgs e)
        {
            dtgv_ThanhTra.Columns.Clear();

            DataTable dt = LoadNhanVien(); // Data table object
            dtgv_ThanhTra.DataSource = dt.DefaultView;
        }

        private void btn_Views_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien form = new ThongTinNhanVien(username, password);
            con.Close();
            form.Show();
        }

        private void fThanhTra_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
        }

        private DataTable LoadBenhNhan()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from DBA_QLBV.BENHNHAN"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadNhanVien()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from DBA_QLBV.NHANVIEN"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadCSYT()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from DBA_QLBV.CSYT"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadHSBA()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from DBA_QLBV.HSBA"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadHSBA_DV()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from DBA_QLBV.HSBA_DV"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        

        private void btn_BenhNhan_Click(object sender, EventArgs e)
        {
            dtgv_ThanhTra.Columns.Clear();

            DataTable dt = LoadBenhNhan(); // Data table object
            dtgv_ThanhTra.DataSource = dt.DefaultView;
        }

        private void btn_CSYT_Click(object sender, EventArgs e)
        {
            dtgv_ThanhTra.Columns.Clear();

            DataTable dt = LoadCSYT(); // Data table object
            dtgv_ThanhTra.DataSource = dt.DefaultView;
        }

        private void btn_HSBA_Click(object sender, EventArgs e)
        {
            dtgv_ThanhTra.Columns.Clear();

            DataTable dt = LoadHSBA(); // Data table object
            dtgv_ThanhTra.DataSource = dt.DefaultView;
        }

        private void btn_HSBADV_Click(object sender, EventArgs e)
        {
            dtgv_ThanhTra.Columns.Clear();

            DataTable dt = LoadHSBA_DV(); // Data table object
            dtgv_ThanhTra.DataSource = dt.DefaultView;
        }
    }
}
