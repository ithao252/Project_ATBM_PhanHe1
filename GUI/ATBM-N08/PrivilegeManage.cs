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
                dtgv_grant_privs.DataSource = BUS_Privilege.Instance.FindRolePrivileges(role_textbox.Text.ToString());
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
                dtgv_grant_privs.DataSource = BUS_Privilege.Instance.FindUserPrivileges(role_textbox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_grant_privs_Click(object sender, EventArgs e)
        {

        }

        private void btn_revoke_privs_Click(object sender, EventArgs e)
        {

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


        private void role_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_textbox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
