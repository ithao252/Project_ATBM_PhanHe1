﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM_N08.DAO;
using ATBM_N08.BUS;

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
        private void btn_Role_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_Role.Height;
            SlidePanel.Top = btn_Role.Top;
            loadform(new ListRole());
        }

        private void controlListUser1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Table_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_Table.Height;
            SlidePanel.Top = btn_Table.Top;
            loadform(new ListTable());
        }

        private void btn_Privilege_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_Privilege.Height;
            SlidePanel.Top = btn_Privilege.Top;
            loadform(new ListPrivilege());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_Home.Height;
            SlidePanel.Top = btn_Home.Top;
            loadform(new Home());

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Views_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_Table.Height;
            SlidePanel.Top = btn_Table.Top;
            loadform(new ListViews());
        }

        private void SlidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
