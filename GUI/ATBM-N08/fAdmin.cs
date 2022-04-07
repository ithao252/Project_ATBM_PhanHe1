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

            
        }

        public void loadform(object Form)
        {
            if (this.userPanel.Controls.Count > 0)
                this.userPanel.Controls.RemoveAt(0);
           Form f = Form as Form;
           f.TopLevel = false;
           f.Dock = DockStyle.Fill;
           this.userPanel.Controls.Add(f);
           this.userPanel.Tag = f;
           f.Show();
  


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button1.Height;
            SlidePanel.Top = button1.Top;
            loadform(new fListUser());
           
        }
        
        private void controlListUser1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button4.Height;
            SlidePanel.Top = button4.Top;
            loadform(new ListTable());
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
            loadform(new ListRole());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            loadform(new Home());

        }
    }
}
