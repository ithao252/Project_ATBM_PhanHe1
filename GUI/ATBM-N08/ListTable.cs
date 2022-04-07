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
    public partial class ListTable : Form
    {
        public ListTable()
        {
            InitializeComponent();
        }

        private void btn_addTable_Click(object sender, EventArgs e)
        {
            AddTable a = new AddTable();
            a.Show();
        }
    }
}
