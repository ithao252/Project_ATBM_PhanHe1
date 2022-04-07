using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM_N08.BUS;

namespace ATBM_N08
{
    public partial class fAddUser : Form
    {
        public fAddUser()
        {
            InitializeComponent();
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            String username = txtbUsername.Text;
            String password = txtbPass.Text;


            try
            {
                BUS_User.Instance.CreateUser(username, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"{username} created successfully!");
        }
    }
}
