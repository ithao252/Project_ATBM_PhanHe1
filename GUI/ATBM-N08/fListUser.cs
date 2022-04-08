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
    public partial class fListUser : Form
    {
        public fListUser()
        {
            InitializeComponent();
            dtgv_User.CellClick += User_Delete_Click;  //Thêm event handler cho các nút
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fAddUser a = new fAddUser();
            a.Show();
        }

       


        private void fListUser_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_User.DataSource = BUS_User.Instance.GetAllUsers();
                DataGridViewButtonColumn deleteUserButtonCol = new DataGridViewButtonColumn();
                deleteUserButtonCol.Name = "Delete";
                deleteUserButtonCol.HeaderText = "";
                deleteUserButtonCol.Text = "Xóa";
                deleteUserButtonCol.UseColumnTextForButtonValue = true;


                if (dtgv_User.Columns["Delete"] == null)
                {
                    dtgv_User.Columns.Add(deleteUserButtonCol);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void User_Delete_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_User.Columns["Delete"] != null &&
                e.ColumnIndex == dtgv_User.Columns["Delete"].Index)
            {
                String username = dtgv_User.Rows[e.RowIndex].Cells["USERNAME"].Value.ToString();
                if (MessageBox.Show("Bạn thật sự muốn xóa user?", "Thông báo",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
                try
                {
                     BUS_User.Instance.DeleteUser(username,true);
                }
                catch (Exception ex)
                {
                        MessageBox.Show(ex.Message);
                        return;
                }

                MessageBox.Show($"{username} droped successfully!");

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateUserInfo u = new UpdateUserInfo();
            u.Show();
        }

        private void dtgv_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
