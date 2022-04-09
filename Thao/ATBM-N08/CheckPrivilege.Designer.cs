namespace ATBM_N08
{
    partial class CheckPrivilege
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_UserName = new System.Windows.Forms.TextBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgv_Privilege_User = new System.Windows.Forms.DataGridView();
            this.dtgv_User_Column = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Privilege_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_User_Column)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Show Privilege (Table) of User:";
            // 
            // txtb_UserName
            // 
            this.txtb_UserName.Location = new System.Drawing.Point(329, 17);
            this.txtb_UserName.Name = "txtb_UserName";
            this.txtb_UserName.Size = new System.Drawing.Size(142, 20);
            this.txtb_UserName.TabIndex = 12;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Check.FlatAppearance.BorderSize = 0;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.Color.White;
            this.btn_Check.Location = new System.Drawing.Point(487, 13);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(112, 26);
            this.btn_Check.TabIndex = 13;
            this.btn_Check.Text = "CHECK";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 550);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtgv_User_Column);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtgv_Privilege_User);
            this.tabPage1.Controls.Add(this.btn_Check);
            this.tabPage1.Controls.Add(this.txtb_UserName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Privilege Table and Column";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgv_Privilege_User
            // 
            this.dtgv_Privilege_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Privilege_User.Location = new System.Drawing.Point(10, 43);
            this.dtgv_Privilege_User.Name = "dtgv_Privilege_User";
            this.dtgv_Privilege_User.Size = new System.Drawing.Size(748, 208);
            this.dtgv_Privilege_User.TabIndex = 0;
            // 
            // dtgv_User_Column
            // 
            this.dtgv_User_Column.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_User_Column.Location = new System.Drawing.Point(10, 281);
            this.dtgv_User_Column.Name = "dtgv_User_Column";
            this.dtgv_User_Column.Size = new System.Drawing.Size(748, 237);
            this.dtgv_User_Column.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Show Privilege (Column) of User:";
            // 
            // CheckPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.tabControl1);
            this.Name = "CheckPrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckPrivilege";
            this.Load += new System.EventHandler(this.CheckPrivilege_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Privilege_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_User_Column)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_UserName;
        private System.Windows.Forms.Button btn_Check;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgv_Privilege_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_User_Column;
    }
}