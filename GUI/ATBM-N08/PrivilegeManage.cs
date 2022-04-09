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
    public partial class PrivilegeManage : Form
    {
        public PrivilegeManage()
        {
            InitializeComponent();
        }

        private void PrivsRole_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_privs.DataSource = BUS_Privilege.Instance.FindRolePrivileges(role_textbox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrivsUser_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_privs.DataSource = BUS_Privilege.Instance.FindUserPrivileges(user_textbox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_findRole_Click(object sender, EventArgs e)
        {
            this.PrivsRole_Load(sender, e);
            role_textbox.Text = "";
        }

        private void btn_findUser_Click(object sender, EventArgs e)
        {
            this.PrivsUser_Load(sender, e);
            user_textbox.Text = "";
        }

        private void btn_grantPrivs_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_Privilege.Instance.GrantPrivilege(grant_to_textbox.Text.ToString(), grant_privs_textbox.Text.ToString(), admin_option.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            grant_to_textbox.Text = "";
            grant_privs_textbox.Text = "";
        }

        private void btn_revokePrivs_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_Privilege.Instance.RevokePrivilege(revoke_from_textbox.Text.ToString(), revoke_privs_textbox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            revoke_from_textbox.Text = "";
            revoke_privs_textbox.Text = "";
        }

        private void role_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void grantTo_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void grantPrivs_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_option_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void revokeFrom_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void revokePrivs_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
