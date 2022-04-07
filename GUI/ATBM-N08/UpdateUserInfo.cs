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
    public partial class UpdateUserInfo : Form
    {
        public UpdateUserInfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_User.Instance.UpdateUser(txtbUsername.Text, (bool)checkbox_Lock.Checked, txtbNewPass.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"Update {txtbUsername.Text} successfully!");
        }
    }
}
