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
    public partial class ListRole : Form
    {
        public ListRole()
        {
            InitializeComponent();
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

        private void ListRole_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_Role.DataSource = BUS_Role.Instance.GetAllRoles();
                //DataGridViewButtonColumn deleteUserButtonCol = new DataGridViewButtonColumn();
                //deleteUserButtonCol.Name = "Delete";
                //deleteUserButtonCol.HeaderText = "";
                //deleteUserButtonCol.Text = "Xóa";
                //deleteUserButtonCol.UseColumnTextForButtonValue = true;

                //if (dtgv_User.Columns["Delete"] == null)
                //{
                //    dtgv_User.Columns.Add(deleteUserButtonCol);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_Role_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
