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
    public partial class ListViews : Form
    {
        public ListViews()
        {
            InitializeComponent();
        }

        //private void btn_addTable_Click(object sender, EventArgs e)
        //{
        //    AddTable add_table = new AddTable();
        //    add_table.Show();
        //}

        private void ListView_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_Views.DataSource = BUS_Views.Instance.GetAllViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListViewOwner_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_Views.DataSource = BUS_Views.Instance.GetOwnerViews(view_owner_textbox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            //TableManage detail_table = new TableManage();
            //detail_table.Show();
        }

        private void view_owner_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_findViewOwner_Click(object sender, EventArgs e)
        {
            this.ListViewOwner_Load(sender, e);
            view_owner_textbox.Text = "";
        }
    }
}
