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
    public partial class DBA_PH2 : Form
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
            catch (Exception ex)
            {
                con.Close();
            }
        }

        public DBA_PH2(string user, string pass)
        {
            username = user;
            password = pass;
            this.setConnection();
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DBA_PH2_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);

            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.Font, FontStyle.Bold);


            // Gridview
            DataTable dt = LoadBenhNhan(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;

            dt = LoadCSYT(); // Data table object
            dataGridView2.DataSource = dt.DefaultView;

            dt = LoadNhanVien(); // Data table object
            dataGridView3.DataSource = dt.DefaultView;

            // Combobox
            DataTable dt2 = LoadCSYT();
            CSYT_cb_tab1.DataSource = dt2;
            CSYT_cb_tab1.DisplayMember = "MACSYT";
            CSYT_cb_tab1.AutoCompleteMode = AutoCompleteMode.Suggest;
            CSYT_cb_tab1.AutoCompleteSource = AutoCompleteSource.ListItems;

            

            VaiTro_cb_tab1.SelectedIndex = 0;
            
        }

        private void DBA_PH2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con != null)
                con.Close();
            Application.ExitThread();
        }



        private DataTable LoadCSYT()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from CSYT"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private DataTable LoadBenhNhan()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from BENHNHAN"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadBenhNhan(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;
        }

        private DataTable LoadNhanVien()
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from NhanVien"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadNhanVien(); // Data table object
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void Grant_Role(string Role, string Username)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "GRANT_ROLE_TO_USER"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            switch (Role)
            {
                case "Thanh Tra":
                    Role = "THANHTRA";
                    break;
                case "Cơ Sở Y Tế":
                    Role = "CSYT";
                    break;
                case "Bác Sĩ":
                    Role = "Y_BACSI";
                    break;
                case "Bệnh Nhân":
                    Role = "BENHNHAN";
                    break;
                case "Nghiên Cứu":
                    Role = "NGHIENCUU";
                    break;
            }
            cmd.Parameters.Add("role_name", OracleDbType.Varchar2, 50).Value = Role;
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2, 50).Value = Username;
            cmd.Parameters.Add("n_option", OracleDbType.Varchar2, 50).Value = null;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Grant success");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Grant_NewUser"; // Sql statement
            cmd.CommandType = CommandType.StoredProcedure; // Type of Sql statement
            cmd.Parameters.Add("User_name", OracleDbType.Varchar2, 100).Value = User_textbox_tab1.Text;
            cmd.Parameters.Add("Pass_Word", OracleDbType.Varchar2, 100).Value = Pass_textbox_tab1.Text;
            cmd.Parameters.Add("vaitro", OracleDbType.NVarchar2, 100).Value = VaiTro_cb_tab1.Text;
            cmd.Parameters.Add("CoSoYTe", OracleDbType.Varchar2, 100).Value = CSYT_cb_tab1.Text;


            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("User Created");
                    Grant_Role(VaiTro_cb_tab1.Text, User_textbox_tab1.Text); // Grant role for new user

                    if (VaiTro_cb_tab1.Text == "Bệnh Nhân")
                    {
                        DataTable dt = LoadBenhNhan(); // Data table object
                        dataGridView1.DataSource = dt.DefaultView;
                    }
                    else
                    {
                        DataTable dt = LoadNhanVien(); // Data table object
                        dataGridView1.DataSource = dt.DefaultView;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_CSYTSearch_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * from CSYT where lower(TENCSYT) like '%' || :tenCS || '%'"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("tenCS", OracleDbType.NVarchar2, 100).Value = textBox1.Text.ToLower();

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            dataGridView2.DataSource = dt.DefaultView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                DataTable dt = LoadCSYT(); // Data table object
                dataGridView2.DataSource = dt.DefaultView;
            }
        }

        private void Manage_CSYT(string sql_stm, int state) 
        {
            string msg = "";
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = sql_stm;
            cmd.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = MACSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("TENCSYT", OracleDbType.Varchar2, 50).Value = TENCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("DCCSYT", OracleDbType.Varchar2, 250).Value = DCCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("SDTCSYT", OracleDbType.Varchar2, 12).Value = SDTCSYT_txtBox_tab2.Text;
                    msg = "Thêm CSYT thành công";
                    break;
                case 1:
                    cmd.Parameters.Add("TENCSYT", OracleDbType.Varchar2, 50).Value = TENCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("DCCSYT", OracleDbType.Varchar2, 250).Value = DCCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("SDTCSYT", OracleDbType.Varchar2, 12).Value = SDTCSYT_txtBox_tab2.Text;
                    cmd.Parameters.Add("MACSYT", OracleDbType.Varchar2, 30).Value = MACSYT_txtBox_tab2.Text;
                    msg = "Update thành công";
                    break;
            }
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    DataTable dt = LoadCSYT();
                    dataGridView2.DataSource = dt.DefaultView;
                }
                else
                {
                    string message = "ERROR";
                    string title = "Warning";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

       

       

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "Insert into CSYT(MACSYT, TENCSYT, DCCSYT, SDTCSYT) " +
                "Values(:MACSYT, :TENCSYT, :DCCSYT, :SDTCSYT)";
            this.Manage_CSYT(sql, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "Update CSYT set " +
               "TENCSYT = :TENCSYT, " +
               "DCCSYT = :DCCSYT, " +
               "SDTCSYT = :SDTCSYT " +
               "Where MACSYT = :MACSYT";
            this.Manage_CSYT(sql, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            button4.Enabled = true;
            button5.Enabled = false;

            MACSYT_txtBox_tab2.Enabled = true;
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1) // Nhan vao header khong tinh
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[index];
                MACSYT_txtBox_tab2.Text = selectedRow.Cells["MACSYT"].Value.ToString();
                TENCSYT_txtBox_tab2.Text = selectedRow.Cells["TENCSYT"].Value.ToString();
                DCCSYT_txtBox_tab2.Text = selectedRow.Cells["DCCSYT"].Value.ToString();
                SDTCSYT_txtBox_tab2.Text = selectedRow.Cells["SDTCSYT"].Value.ToString();
            }

            button4.Enabled = false;
            button5.Enabled = true;

            MACSYT_txtBox_tab2.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText =
                "Insert into NHANVIEN(MANV, HOTEN, PHAI, NGAYSINH, CMND, QUEQUAN, SODT, CSYT, VAITRO, CHUYENKHOA) " +
                "Values(:MANV, :HOTEN, :PHAI, :NGAYSINH, :CMND, :QUEQUAN, :SODT, :CSYT, :VAITRO, :CHUYENKHOA)"; // Sql statement
            cmd.CommandType = CommandType.Text; // Type of Sql statement
            cmd.Parameters.Add("MANV", OracleDbType.Varchar2, 30).Value = txtb_MaNV.Text;
            cmd.Parameters.Add("HOTEN", OracleDbType.NVarchar2, 50).Value = txtb_Ten.Text;
            cmd.Parameters.Add("PHAI", OracleDbType.NVarchar2, 20).Value = txtb_Phai.Text;
            cmd.Parameters.Add("NGAYSINH", OracleDbType.Date).Value = dateTimePicker1.Value.Date;
            cmd.Parameters.Add("CMND", OracleDbType.Varchar2, 12).Value = txtb_CMND.Text;
            cmd.Parameters.Add("QUEQUAN", OracleDbType.NVarchar2, 50).Value = txtb_Que.Text;
            cmd.Parameters.Add("SODT", OracleDbType.Varchar2, 50).Value = txtb_SDT.Text;
            cmd.Parameters.Add("CSYT", OracleDbType.Varchar2, 30).Value = txtb_CSYT.Text;
            cmd.Parameters.Add("VAITRO", OracleDbType.NVarchar2, 50).Value = txtb_VaiTro.Text;
            cmd.Parameters.Add("CHUYENKHOA", OracleDbType.NVarchar2, 50).Value = txtb_ChuyenKhoa.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    MessageBox.Show("Thêm Nhân viên thành công");
                    DataTable dt = LoadNhanVien(); // Data table object
                    dataGridView3.DataSource = dt.DefaultView;
                }
                else
                {
                    string message = "ERROR";
                    string title = "Warning";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
