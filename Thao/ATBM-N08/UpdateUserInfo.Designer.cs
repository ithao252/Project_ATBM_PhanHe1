namespace ATBM_N08
{
    partial class UpdateUserInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Username = new System.Windows.Forms.Label();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Password = new System.Windows.Forms.Label();
            this.txtbNewPass = new System.Windows.Forms.TextBox();
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkbox_Lock = new System.Windows.Forms.CheckBox();
            this.checkbox_Unlock = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Username);
            this.panel1.Controls.Add(this.txtbUsername);
            this.panel1.Location = new System.Drawing.Point(22, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 36);
            this.panel1.TabIndex = 4;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(3, 17);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(58, 13);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username:";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(88, 13);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(133, 20);
            this.txtbUsername.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Password);
            this.panel2.Controls.Add(this.txtbNewPass);
            this.panel2.Location = new System.Drawing.Point(22, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 36);
            this.panel2.TabIndex = 5;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(3, 17);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(81, 13);
            this.label_Password.TabIndex = 0;
            this.label_Password.Text = "New Password:";
            // 
            // txtbNewPass
            // 
            this.txtbNewPass.Location = new System.Drawing.Point(90, 14);
            this.txtbNewPass.Name = "txtbNewPass";
            this.txtbNewPass.Size = new System.Drawing.Size(133, 20);
            this.txtbNewPass.TabIndex = 1;
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_UpdateUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateUser.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateUser.Location = new System.Drawing.Point(49, 126);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(186, 28);
            this.btn_UpdateUser.TabIndex = 6;
            this.btn_UpdateUser.Text = "Confirm";
            this.btn_UpdateUser.UseVisualStyleBackColor = false;
            this.btn_UpdateUser.Click += new System.EventHandler(this.btn_UpdateUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phân quyền theo mức bảng:";
            // 
            // checkbox_Lock
            // 
            this.checkbox_Lock.AutoSize = true;
            this.checkbox_Lock.Location = new System.Drawing.Point(55, 90);
            this.checkbox_Lock.Name = "checkbox_Lock";
            this.checkbox_Lock.Size = new System.Drawing.Size(50, 17);
            this.checkbox_Lock.TabIndex = 8;
            this.checkbox_Lock.Text = "Lock";
            this.checkbox_Lock.UseVisualStyleBackColor = true;
            // 
            // checkbox_Unlock
            // 
            this.checkbox_Unlock.AutoSize = true;
            this.checkbox_Unlock.Location = new System.Drawing.Point(123, 90);
            this.checkbox_Unlock.Name = "checkbox_Unlock";
            this.checkbox_Unlock.Size = new System.Drawing.Size(60, 17);
            this.checkbox_Unlock.TabIndex = 9;
            this.checkbox_Unlock.Text = "Unlock";
            this.checkbox_Unlock.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(752, 187);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 536);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btn_UpdateUser);
            this.tabPage1.Controls.Add(this.checkbox_Lock);
            this.tabPage1.Controls.Add(this.checkbox_Unlock);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Change Password";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Privilege (Table)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Location = new System.Drawing.Point(10, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(752, 201);
            this.panel6.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(298, 476);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 28);
            this.button4.TabIndex = 20;
            this.button4.Text = "Confirm";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nhập user:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 20);
            this.textBox3.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(415, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Kiểm tra quyền";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(752, 198);
            this.dataGridView2.TabIndex = 22;
            // 
            // UpdateUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.tabControl1);
            this.Name = "UpdateUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateUserInfo";
            this.Load += new System.EventHandler(this.UpdateUserInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox txtbNewPass;
        private System.Windows.Forms.Button btn_UpdateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkbox_Lock;
        private System.Windows.Forms.CheckBox checkbox_Unlock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}