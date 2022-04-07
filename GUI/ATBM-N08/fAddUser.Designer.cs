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
            this.panel1.Location = new System.Drawing.Point(152, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 69);
            this.panel1.TabIndex = 3;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(6, 33);
            this.label_Username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(116, 25);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username:";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(128, 27);
            this.txtbUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(262, 31);
            this.txtbUsername.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Password);
            this.panel2.Controls.Add(this.txtbPass);
            this.panel2.Location = new System.Drawing.Point(564, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 69);
            this.panel2.TabIndex = 4;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(6, 33);
            this.label_Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(112, 25);
            this.label_Password.TabIndex = 0;
            this.label_Password.Text = "Password:";
            // 
            // txtbPass
            // 
            this.txtbPass.Location = new System.Drawing.Point(128, 27);
            this.txtbPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(262, 31);
            this.txtbPass.TabIndex = 1;
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateUser.ForeColor = System.Drawing.Color.White;
            this.btn_CreateUser.Location = new System.Drawing.Point(996, 35);
            this.btn_CreateUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(372, 54);
            this.btn_CreateUser.TabIndex = 5;
            this.btn_CreateUser.Text = "Tạo mới";
            this.btn_CreateUser.UseVisualStyleBackColor = false;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Check information:";
            // 
            // tabControl_User
            // 
            this.tabControl_User.Controls.Add(this.tabPage_Role);
            this.tabControl_User.Controls.Add(this.tabPage_Privilege);
            this.tabControl_User.Controls.Add(this.tabPage_Table);
            this.tabControl_User.Location = new System.Drawing.Point(36, 169);
            this.tabControl_User.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl_User.Name = "tabControl_User";
            this.tabControl_User.SelectedIndex = 0;
            this.tabControl_User.Size = new System.Drawing.Size(1464, 615);
            this.tabControl_User.TabIndex = 7;
            // 
            // tabPage_Role
            // 
            this.tabPage_Role.Controls.Add(this.dataGridView_Role);
            this.tabPage_Role.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Role.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage_Role.Name = "tabPage_Role";
            this.tabPage_Role.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage_Role.Size = new System.Drawing.Size(1448, 568);
            this.tabPage_Role.TabIndex = 0;
            this.tabPage_Role.Text = "Xem roles";
            this.tabPage_Role.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Role
            // 
            this.dataGridView_Role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Role.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Role.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView_Role.Name = "dataGridView_Role";
            this.dataGridView_Role.RowHeadersWidth = 82;
            this.dataGridView_Role.Size = new System.Drawing.Size(1424, 542);
            this.dataGridView_Role.TabIndex = 0;
            // 
            // tabPage_Privilege
            // 
            this.tabPage_Privilege.Controls.Add(this.dataGridView_Privilege);
            this.tabPage_Privilege.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Privilege.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage_Privilege.Name = "tabPage_Privilege";
            this.tabPage_Privilege.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage_Privilege.Size = new System.Drawing.Size(1448, 568);
            this.tabPage_Privilege.TabIndex = 1;
            this.tabPage_Privilege.Text = "Xem privilege";
            this.tabPage_Privilege.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Privilege
            // 
            this.dataGridView_Privilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Privilege.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Privilege.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView_Privilege.Name = "dataGridView_Privilege";
            this.dataGridView_Privilege.RowHeadersWidth = 82;
            this.dataGridView_Privilege.Size = new System.Drawing.Size(1316, 469);
            this.dataGridView_Privilege.TabIndex = 0;
            // 
            // tabPage_Table
            // 
            this.tabPage_Table.Controls.Add(this.dataGridView_Table);
            this.tabPage_Table.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Table.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage_Table.Name = "tabPage_Table";
            this.tabPage_Table.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage_Table.Size = new System.Drawing.Size(1448, 568);
            this.tabPage_Table.TabIndex = 2;
            this.tabPage_Table.Text = "Xem table ";
            this.tabPage_Table.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Table
            // 
            this.dataGridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Table.Location = new System.Drawing.Point(6, 12);
            this.dataGridView_Table.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView_Table.Name = "dataGridView_Table";
            this.dataGridView_Table.RowHeadersWidth = 82;
            this.dataGridView_Table.Size = new System.Drawing.Size(1322, 463);
            this.dataGridView_Table.TabIndex = 0;
            // 
            // fAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 802);
            this.Controls.Add(this.tabControl_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Add User";
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