namespace ATBM_N08
{
    partial class fAddUser
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
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_User = new System.Windows.Forms.TabControl();
            this.tabPage_Role = new System.Windows.Forms.TabPage();
            this.dataGridView_Role = new System.Windows.Forms.DataGridView();
            this.tabPage_Privilege = new System.Windows.Forms.TabPage();
            this.dataGridView_Privilege = new System.Windows.Forms.DataGridView();
            this.tabPage_Table = new System.Windows.Forms.TabPage();
            this.dataGridView_Table = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl_User.SuspendLayout();
            this.tabPage_Role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Role)).BeginInit();
            this.tabPage_Privilege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Privilege)).BeginInit();
            this.tabPage_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Username);
            this.panel1.Controls.Add(this.txtbUsername);
            this.panel1.Location = new System.Drawing.Point(76, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 36);
            this.panel1.TabIndex = 3;
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
            this.txtbUsername.Location = new System.Drawing.Point(64, 14);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(133, 20);
            this.txtbUsername.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Password);
            this.panel2.Controls.Add(this.txtbPass);
            this.panel2.Location = new System.Drawing.Point(282, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 36);
            this.panel2.TabIndex = 4;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(3, 17);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(56, 13);
            this.label_Password.TabIndex = 0;
            this.label_Password.Text = "Password:";
            // 
            // txtbPass
            // 
            this.txtbPass.Location = new System.Drawing.Point(64, 14);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(133, 20);
            this.txtbPass.TabIndex = 1;
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateUser.ForeColor = System.Drawing.Color.White;
            this.btn_CreateUser.Location = new System.Drawing.Point(498, 18);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(186, 28);
            this.btn_CreateUser.TabIndex = 5;
            this.btn_CreateUser.Text = "Tạo mới";
            this.btn_CreateUser.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Check information:";
            // 
            // tabControl_User
            // 
            this.tabControl_User.Controls.Add(this.tabPage_Role);
            this.tabControl_User.Controls.Add(this.tabPage_Privilege);
            this.tabControl_User.Controls.Add(this.tabPage_Table);
            this.tabControl_User.Location = new System.Drawing.Point(18, 88);
            this.tabControl_User.Name = "tabControl_User";
            this.tabControl_User.SelectedIndex = 0;
            this.tabControl_User.Size = new System.Drawing.Size(732, 320);
            this.tabControl_User.TabIndex = 7;
            // 
            // tabPage_Role
            // 
            this.tabPage_Role.Controls.Add(this.dataGridView_Role);
            this.tabPage_Role.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Role.Name = "tabPage_Role";
            this.tabPage_Role.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Role.Size = new System.Drawing.Size(724, 294);
            this.tabPage_Role.TabIndex = 0;
            this.tabPage_Role.Text = "Xem roles";
            this.tabPage_Role.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Role
            // 
            this.dataGridView_Role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Role.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Role.Name = "dataGridView_Role";
            this.dataGridView_Role.Size = new System.Drawing.Size(712, 282);
            this.dataGridView_Role.TabIndex = 0;
            // 
            // tabPage_Privilege
            // 
            this.tabPage_Privilege.Controls.Add(this.dataGridView_Privilege);
            this.tabPage_Privilege.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Privilege.Name = "tabPage_Privilege";
            this.tabPage_Privilege.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Privilege.Size = new System.Drawing.Size(724, 294);
            this.tabPage_Privilege.TabIndex = 1;
            this.tabPage_Privilege.Text = "Xem privilege";
            this.tabPage_Privilege.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Privilege
            // 
            this.dataGridView_Privilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Privilege.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Privilege.Name = "dataGridView_Privilege";
            this.dataGridView_Privilege.Size = new System.Drawing.Size(658, 244);
            this.dataGridView_Privilege.TabIndex = 0;
            // 
            // tabPage_Table
            // 
            this.tabPage_Table.Controls.Add(this.dataGridView_Table);
            this.tabPage_Table.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Table.Name = "tabPage_Table";
            this.tabPage_Table.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Table.Size = new System.Drawing.Size(724, 294);
            this.tabPage_Table.TabIndex = 2;
            this.tabPage_Table.Text = "Xem table ";
            this.tabPage_Table.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Table
            // 
            this.dataGridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Table.Location = new System.Drawing.Point(3, 6);
            this.dataGridView_Table.Name = "dataGridView_Table";
            this.dataGridView_Table.Size = new System.Drawing.Size(661, 241);
            this.dataGridView_Table.TabIndex = 0;
            // 
            // fAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 417);
            this.Controls.Add(this.tabControl_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl_User.ResumeLayout(false);
            this.tabPage_Role.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Role)).EndInit();
            this.tabPage_Privilege.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Privilege)).EndInit();
            this.tabPage_Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.Button btn_CreateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_User;
        private System.Windows.Forms.TabPage tabPage_Role;
        private System.Windows.Forms.DataGridView dataGridView_Role;
        private System.Windows.Forms.TabPage tabPage_Privilege;
        private System.Windows.Forms.DataGridView dataGridView_Privilege;
        private System.Windows.Forms.TabPage tabPage_Table;
        private System.Windows.Forms.DataGridView dataGridView_Table;
    }
}