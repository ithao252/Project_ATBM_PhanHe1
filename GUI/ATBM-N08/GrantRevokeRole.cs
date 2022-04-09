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
    public partial class GrantRevokeRole : Form
    {
        public GrantRevokeRole()
        {
            InitializeComponent();
        }

        private void GrantRevokeRole_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grant_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void commitGrant_Click(object sender, EventArgs e)
        {
            String user = tbUser1.Text;
            String role = tbRole1.Text;
            try
            {
                BUS_Role.Instance.GrantRoleToUser(user, role);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"{role} is granted to {user} successfully!");
        }

        private void ListRoleUser_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_RoleUser.DataSource = BUS_Role.Instance.GetRoleUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            this.ListRoleUser_Load(sender, e);
        }

        private void dtgv_RoleUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void commitRevoke_Click(object sender, EventArgs e)
        {
            String user = tbUser2.Text;
            String role = tbRole2.Text;
            try
            {
                BUS_Role.Instance.RevokeRoleFromUser(user, role);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"{role} is revoked from {user} successfully!");
        }
    }
}
