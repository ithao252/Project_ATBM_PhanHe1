using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM_N08.DAO;
using Oracle.DataAccess.Client;
using System.Collections.ObjectModel;
using ATBM_N08.BUS;
using ATBM_N08.DTO;

namespace ATBM_N08
{
    public partial class CheckRole : Form
    {
        public CheckRole()
        {
            InitializeComponent();
        }

        private void CheckRole_Load(object sender, EventArgs e)
        {

        }

       

        private void btn_Check_Click(object sender, EventArgs e)
        {
            bool checkExistUser = BUS_User.Instance.CheckUser(txtb_UserName.Text);
            if (!checkExistUser)
            {
                MessageBox.Show("KHÔNG TÌM THẤY USER NÀY!", "Oops");
                return;
            }
            dtgv_Role_User.DataSource = BUS_Role.Instance.GetRolesOfUser(txtb_UserName.Text);
        }
    }
}
