using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_N08
{
    public partial class ListRole : Form
    {
        public ListRole()
        {
            InitializeComponent();
        }

        private void dtgv_ListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_createRole_Click(object sender, EventArgs e)
        {
            createRole c = new createRole();
            c.Show();
        }

        private void btn_updateRole_Click(object sender, EventArgs e)
        {
            updateRole u = new updateRole();
            u.Show();
        }

        private void btn_deleteRole_Click(object sender, EventArgs e)
        {
            deleteRole d = new deleteRole();
            d.Show();
        }

        private void btn_grant_revokeRole_Click(object sender, EventArgs e)
        {
            GrantRevokeRole g = new GrantRevokeRole();
            g.Show();
        }
    }
}
