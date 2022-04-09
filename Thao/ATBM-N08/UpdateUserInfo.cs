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
using ATBM_N08.DTO;
using System.Collections.ObjectModel;


namespace ATBM_N08
{
    public partial class UpdateUserInfo : Form
    {
        public UpdateUserInfo()
        {
            InitializeComponent();
        }

        private ObservableCollection<DTO_Privilege_Table> privilegesOnTableList = null;
        private List<ObservableCollection<DTO_PrivilegeOnColumn>> privilegeOnColumns = null;
        private ObservableCollection<DTO_PrivilegeOnColumn> list;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_User.Instance.UpdateUser(txtbUsername.Text, (bool)checkbox_Lock.Checked, txtbNewPass.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show($"Update {txtbUsername.Text} successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckPrivilege p = new CheckPrivilege();
            p.Show();
        }

        private void UpdateUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkExistUser = BUS_User.Instance.CheckUser(textBox3.Text);
                if (!checkExistUser)
                {
                    
                        MessageBox.Show("KHÔNG TÌM THẤY USER NÀY!", "Error");
                        return;
                    
                }
                panel6.Visible = Visible;
                privilegesOnTableList = BUS_Privilege_Table.Instance.GetPrivilegesAllTables(textBox3.Text);
                dataGridView1.DataSource = privilegesOnTableList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                BUS_Privilege_Table.Instance.ExecPrivilegeOnTable(privilegesOnTableList, textBox3.Text);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String tableName = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String username = textBox3.Text;
            try
            {
                dataGridView2.DataSource = BUS_Privilege_Column.Instance.GetPrivilegesAllColumns(username, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }




        }

       

    }
}
