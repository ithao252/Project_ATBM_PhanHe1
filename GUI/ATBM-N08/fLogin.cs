using ATBM_N08.BUS;
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
    public partial class fLogin : Form
    {
        private OracleConnection con = null;
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private bool Check_Role(int option)
        {
            

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text; // Type of Sql statement

            switch (option)
            {
                case 0:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'DBA'"; // Sql statement
                    break;
                case 1:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'Y_BACSI'"; // Sql statement
                    break;
                case 2:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'BENHNHAN'"; // Sql statement
                    break;
                case 3:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'THANHTRA'"; // Sql statement
                    break;
                case 4:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'NGHIENCUU'"; // Sql statement
                    break;
                case 5:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'CSYT'"; // Sql statement
                    break;
                case 6:
                    cmd.CommandText =
                        "SELECT granted_role " +
                        "FROM USER_ROLE_PRIVS " +
                        "Where granted_role = 'DBA_PH2'"; // Sql statement
                    break;
            }

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(); // Data table object
            da.Fill(dt);

            int count = dt.Rows.Count;
            if (count == 1)
            {
                // DBA_BV dang nhap vo tai khoan khac
                if (txtUsername.Text == "DBA_QLBV" && (cb_VaiTro.Text == "Admin" ))
                    return true;
                else if (txtUsername.Text != "DBA_QLBV")
                    return true;
                return false;
            }
            else
            {
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text.ToString();
            string connectionString = $"Data Source=localhost/XE;User ID = {username}; Password={password}";
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            string err_str = "Username không đúng với vai trò";
            switch (cb_VaiTro.SelectedItem)
            {
                case "Admin":
                    // Check exist
                    if (Check_Role(0) == true)
                    {
                        MessageBox.Show("Welcome DBA");

                        

                        fAdmin fr = new fAdmin();
                        con.Close();
                        fr.ShowDialog();

                        
                    }
                    else
                        MessageBox.Show(err_str, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Thanh Tra":
                    if (Check_Role(3) == true)
                    {
                        this.Hide();

                        fThanhTra fr= new fThanhTra(username, password);
                        con.Close();
                        fr.ShowDialog();

                        
                    }
                    else
                        MessageBox.Show(err_str, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Cơ Sở Y Tế":
                    if (Check_Role(5) == true)
                    {
                        this.Hide();

                        
                    }
                    else
                        MessageBox.Show(err_str, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Bác Sĩ":
                    if (Check_Role(1) == true)
                    {
                        this.Hide();

                        
                    }
                    else
                        MessageBox.Show(err_str, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Bệnh Nhân":
                    if (Check_Role(2) == true)
                    {
                        this.Hide();

                       
                    }
                    else
                        MessageBox.Show(err_str, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Nghiên Cứu":
                    if (Check_Role(4) == true)
                    {
                        this.Hide();

                        fNghienCuu fr = new fNghienCuu(username, password);
                        con.Close();
                        fr.ShowDialog();
                    }
                    else
                        MessageBox.Show(err_str, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Admin 2":
                    if (Check_Role(0) == true)
                    {
                        this.Hide();

                       
                    }
                    else
                        MessageBox.Show(err_str, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            con.Close();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel=true;
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
