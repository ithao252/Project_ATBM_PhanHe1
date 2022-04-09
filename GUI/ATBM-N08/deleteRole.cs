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
    public partial class deleteRole : Form
    {
        public deleteRole()
        {
            InitializeComponent();
        }

        private void btn_deleteRole_Click(object sender, EventArgs e)
        {
            String role = tbRole.Text;
            try
            {
                BUS_Role.Instance.DeleteRole(role);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"{role} is deleted successfully!");
        }
    }
}
