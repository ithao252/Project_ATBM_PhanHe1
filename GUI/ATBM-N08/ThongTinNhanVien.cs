using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_N08
{
    public partial class ThongTinNhanVien : Form
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
        public ThongTinNhanVien(string user, string pass)
        {
            username = user;
            password = pass;

            this.setConnection();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from DBA_QLBV.NV_xem_thong_tin"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            txtb_MaNV.Text = dt.Rows[0].Field<string>("MANV");
            txtb_HoTen.Text = dt.Rows[0].Field<string>("HOTEN");
            txtb_Phai.Text = dt.Rows[0].Field<string>("PHAI");
            dateTimePicker1.Value = dt.Rows[0].Field<DateTime>("NGAYSINH");
            txtb_CMND.Text = dt.Rows[0].Field<string>("CMND");
            txtb_Que.Text = dt.Rows[0].Field<string>("QUEQUAN");
            txtb_SDT.Text = dt.Rows[0].Field<string>("SODT");
            txtb_CSYT.Text = dt.Rows[0].Field<string>("CSYT");
            txtb_VaiTro.Text = dt.Rows[0].Field<string>("VAITRO");
            txtb_ChuyenKhoa.Text = dt.Rows[0].Field<string>("CHUYENKHOA");

            
        }

        private void ThongTinNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();

            cmd.CommandText =
                 "Update NV_xem_thong_tin set " +
                "HOTEN = :HOTEN, " +
                "PHAI = :PHAI, " +
                "NGAYSINH = :NGAYSINH, " +
                "CMND = :CMND, " +
                "QUEQUAN = :QUEQUAN, " +
                "CSYT = :CSYT, " +
                "VAITRO = :VAITRO, " +
                "CHUYENKHOA = :CHUYENKHOA "; ; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            cmd.Parameters.Add("HOTEN", OracleDbType.NVarchar2, 50).Value = txtb_HoTen.Text;
            cmd.Parameters.Add("PHAI", OracleDbType.NVarchar2, 20).Value = txtb_Phai.Text;
            cmd.Parameters.Add("NGAYSINH", OracleDbType.Date).Value = dateTimePicker1.Value.Date;
            cmd.Parameters.Add("CMND", OracleDbType.Varchar2, 15).Value = txtb_CMND.Text;
            cmd.Parameters.Add("QUEQUAN", OracleDbType.NVarchar2, 250).Value = txtb_Que.Text;
            cmd.Parameters.Add("CSYT", OracleDbType.Varchar2, 30).Value = txtb_CSYT.Text;
            cmd.Parameters.Add("VAITRO", OracleDbType.NVarchar2, 100).Value = txtb_VaiTro.Text;
           cmd.Parameters.Add("CHUYENKHOA", OracleDbType.NVarchar2, 100).Value = txtb_ChuyenKhoa.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Update Successfull");
                }
                else
                {
                    string message = "Nothing Happened";
                    string title = "Warning";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien_Load(this, EventArgs.Empty);
        }
    }
}
