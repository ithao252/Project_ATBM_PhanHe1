namespace ATBM_N08
{
    partial class PrivilegeManage
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
            this.btn_grant_privs = new System.Windows.Forms.Button();
            this.btn_revoke_privs = new System.Windows.Forms.Button();
            this.role_label = new System.Windows.Forms.Label();
            this.role_textbox = new System.Windows.Forms.TextBox();
            this.btn_find_role = new System.Windows.Forms.Button();
            this.user_label = new System.Windows.Forms.Label();
            this.user_textbox = new System.Windows.Forms.TextBox();
            this.btn_find_user = new System.Windows.Forms.Button();
            this.dtgv_grant_privs = new System.Windows.Forms.DataGridView();
            this.dtgv_revoke_privs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_grant_privs)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_grant_privs
            // 
            this.btn_grant_privs.Location = new System.Drawing.Point(30, 15);
            this.btn_grant_privs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_grant_privs.Name = "btn_grant_privs";
            this.btn_grant_privs.Size = new System.Drawing.Size(263, 28);
            this.btn_grant_privs.TabIndex = 0;
            this.btn_grant_privs.Text = "Grant Privilege to User/Role";
            this.btn_grant_privs.UseVisualStyleBackColor = true;
            this.btn_grant_privs.Click += new System.EventHandler(this.btn_grant_privs_Click);
            // 
            // btn_revoke_privs
            // 
            this.btn_revoke_privs.Location = new System.Drawing.Point(30, 50);
            this.btn_revoke_privs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_revoke_privs.Name = "btn_revoke_privs";
            this.btn_revoke_privs.Size = new System.Drawing.Size(263, 28);
            this.btn_revoke_privs.TabIndex = 0;
            this.btn_revoke_privs.Text = "Revoke Privilege from User/Role";
            this.btn_revoke_privs.UseVisualStyleBackColor = true;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Location = new System.Drawing.Point(400, 20);
            this.role_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(100, 20);
            this.role_label.TabIndex = 1;
            this.role_label.Text = "Role:";
            // 
            // role_textbox
            // 
            this.role_textbox.Location = new System.Drawing.Point(450, 15);
            this.role_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.role_textbox.Name = "role_textbox";
            this.role_textbox.Size = new System.Drawing.Size(300, 20);
            this.role_textbox.TabIndex = 2;
            this.role_textbox.TextChanged += new System.EventHandler(this.role_textbox_TextChanged);
            // 
            // btn_find_role
            // 
            this.btn_find_role.Location = new System.Drawing.Point(760, 12);
            this.btn_find_role.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_find_role.Name = "btn_find_role";
            this.btn_find_role.Size = new System.Drawing.Size(100, 28);
            this.btn_find_role.TabIndex = 4;
            this.btn_find_role.Text = "Find Role";
            this.btn_find_role.UseVisualStyleBackColor = true;
            this.btn_find_role.Click += new System.EventHandler(this.btn_findRole_Click);
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(400, 60);
            this.user_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(100, 20);
            this.user_label.TabIndex = 1;
            this.user_label.Text = "User:";
            // 
            // user_textbox
            // 
            this.user_textbox.Location = new System.Drawing.Point(450, 55);
            this.user_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_textbox.Name = "user_textbox";
            this.user_textbox.Size = new System.Drawing.Size(300, 20);
            this.user_textbox.TabIndex = 2;
            this.user_textbox.TextChanged += new System.EventHandler(this.user_textbox_TextChanged);
            // 
            // btn_find_user
            // 
            this.btn_find_user.Location = new System.Drawing.Point(760, 52);
            this.btn_find_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_find_user.Name = "btn_find_user";
            this.btn_find_user.Size = new System.Drawing.Size(100, 28);
            this.btn_find_user.TabIndex = 4;
            this.btn_find_user.Text = "Find User";
            this.btn_find_user.UseVisualStyleBackColor = true;
            this.btn_find_user.Click += new System.EventHandler(this.btn_findUser_Click);
            // 
            // dtgv_privs
            // 
            this.dtgv_grant_privs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_grant_privs.Location = new System.Drawing.Point(30, 100);
            this.dtgv_grant_privs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv_grant_privs.Name = "dtgv_privs";
            this.dtgv_grant_privs.RowHeadersWidth = 51;
            this.dtgv_grant_privs.Size = new System.Drawing.Size(1000, 500);
            this.dtgv_grant_privs.TabIndex = 1;
            // 
            // PrivilegeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgv_grant_privs);
            this.Controls.Add(this.btn_revoke_privs);
            this.Controls.Add(this.btn_grant_privs);
            this.Controls.Add(this.role_label);
            this.Controls.Add(this.role_textbox);
            this.Controls.Add(this.btn_find_role);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.user_textbox);
            this.Controls.Add(this.btn_find_user);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrivilegeManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrivilegeManage";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_grant_privs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_grant_privs;
        private System.Windows.Forms.Button btn_revoke_privs;
        private System.Windows.Forms.DataGridView dtgv_grant_privs;
        private System.Windows.Forms.DataGridView dtgv_revoke_privs;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.TextBox role_textbox;
        private System.Windows.Forms.Button btn_find_role;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.TextBox user_textbox;
        private System.Windows.Forms.Button btn_find_user;
    }
}