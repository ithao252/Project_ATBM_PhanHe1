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
    public partial class TableManage : Form
    {
        public TableManage()
        {
            InitializeComponent();
        }

        private void TableManage_Load(object sender, EventArgs e)
        {
            try
            {
                dtgv_table.DataSource = BUS_Table.Instance.GetDetailTable(table_name_textbox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_findTable_Click(object sender, EventArgs e)
        {
            this.TableManage_Load(sender, e);
            table_name_textbox.Text = "";
        }

        private void table_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
