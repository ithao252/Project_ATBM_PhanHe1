using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_N08
{
    public partial class TableManage : Form
    {
        public TableManage()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(dataGridView1.Rows.Count-1, table_name_textbox.Text.ToString(), "a");
            table_name_textbox.Text = "";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void table_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
