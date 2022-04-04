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
    public partial class fAdmin : Form
    {
        
        public fAdmin()
        { 
            InitializeComponent();
            SlidePanel.Height = button1.Height;

            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button1.Height;
            SlidePanel.Top = button1.Top;
            controlListUser1.BringToFront();
        }

        private void controlListUser1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button4.Height;
            SlidePanel.Top = button4.Top;
            TableManage t = new TableManage();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button3.Height;
            SlidePanel.Top = button3.Top;
            PrivilegeManage p = new PrivilegeManage();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button2.Height;
            SlidePanel.Top = button2.Top;
            RoleManage r = new RoleManage();
            r.Show();
        }
    }
}
