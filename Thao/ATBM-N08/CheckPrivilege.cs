using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using ATBM_N08.BUS;
using ATBM_N08.DTO;

namespace ATBM_N08
{
    public partial class CheckPrivilege : Form
    {
        public CheckPrivilege()
        {
            InitializeComponent();
        }

        

        private void btn_Check_Click(object sender, EventArgs e)
        {
            String username = txtb_UserName.Text;
            ObservableCollection<DTO_Privilege_Table> privilegeOnTables;
            ObservableCollection<DTO_PrivilegeOnColumn> privilegeOnColumns;
            ObservableCollection<DTO_PrivilegeOnColumn> tmp;
            try
            {
                privilegeOnTables = BUS_Privilege_Table.Instance.GetPrivilegesOnTable(username);
                privilegeOnColumns = BUS_Privilege_Column.Instance.GetPrivilegesOnColumnSelect(username);
                tmp = BUS_Privilege_Column.Instance.GetPrivilegeOnColumnUpdateInsert(username);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            for (int i = 0; i < tmp.Count; i++)
            {
                privilegeOnColumns.Add(tmp[i]);
            }



            dtgv_Privilege_User.DataSource = privilegeOnTables;
            dtgv_User_Column.DataSource = privilegeOnColumns;

        }




        private void CheckPrivilege_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
