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
    public partial class ListPrivilege : Form
    {
        public ListPrivilege()
        {
            InitializeComponent();
        }

        private void btn_managePrivilege_Click(object sender, EventArgs e)
        {
            PrivilegeManage manage_privilege = new PrivilegeManage();
            manage_privilege.Show();
        }

        private void ListPrivilege_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_Privilege.DataSource = BUS_Privilege.Instance.GetAllPrivileges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
