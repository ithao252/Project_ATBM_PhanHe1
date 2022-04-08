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
    public partial class ListTable : Form
    {
        public ListTable()
        {
            InitializeComponent();
        }

        private void btn_addTable_Click(object sender, EventArgs e)
        {
            AddTable add_table = new AddTable();
            add_table.Show();
        }

        private void ListTable_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_Table.DataSource = BUS_Table.Instance.GetAllTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListTableOwner_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_Table.DataSource = BUS_Table.Instance.GetOwnerTables(table_owner_textbox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            TableManage detail_table = new TableManage();
            detail_table.Show();
        }

        private void table_owner_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_findTableOwner_Click(object sender, EventArgs e)
        {
            this.ListTableOwner_Load(sender, e);
            table_owner_textbox.Text = "";
        }
    }
}
