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
    public partial class createRole : Form
    {
        public createRole()
        {
            InitializeComponent();
        }

        private void createRole_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_createRole_Click(object sender, EventArgs e)
        {
            String role = tbRole.Text;
            String password = tbPass.Text;
            int result = cb_withoutpass.CheckState == CheckState.Checked ? 1 : 0;
            try
            {
                BUS_Role.Instance.CreateRole(role, password, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"{role} is created successfully!");
        }

        private void btn_withoutpass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_withoutpass_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
