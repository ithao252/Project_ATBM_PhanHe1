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
    public partial class updateRole : Form
    {
        public updateRole()
        {
            InitializeComponent();
        }

        private void updateRole_Load(object sender, EventArgs e)
        {

        }

        private void tbNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_updateRole_Click(object sender, EventArgs e)
        {
            String role = tbRole.Text;
            String newpassword = tbNewPass.Text;

            int result = cb_withoutpass.CheckState == CheckState.Checked ? 1 : 0;
            try
            {
                BUS_Role.Instance.UpdateRole(role, newpassword, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"{role} is updated successfully!");
        }

        private void cb_withoutpass_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
