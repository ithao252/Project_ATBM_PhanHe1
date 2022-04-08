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
            this.grant_label = new System.Windows.Forms.Label();
            this.grant_to_label = new System.Windows.Forms.Label();
            this.grant_to_textbox = new System.Windows.Forms.TextBox();
            this.grant_privs_label = new System.Windows.Forms.Label();
            this.grant_privs_textbox = new System.Windows.Forms.TextBox();
            this.admin_option = new System.Windows.Forms.CheckBox();
            this.btn_grant_privs = new System.Windows.Forms.Button();
            this.revoke_label = new System.Windows.Forms.Label();
            this.revoke_from_label = new System.Windows.Forms.Label();
            this.revoke_from_textbox = new System.Windows.Forms.TextBox();
            this.revoke_privs_label = new System.Windows.Forms.Label();
            this.revoke_privs_textbox = new System.Windows.Forms.TextBox();
            this.btn_revoke_privs = new System.Windows.Forms.Button();
            this.role_label = new System.Windows.Forms.Label();
            this.role_textbox = new System.Windows.Forms.TextBox();
            this.btn_find_role = new System.Windows.Forms.Button();
            this.user_label = new System.Windows.Forms.Label();
            this.user_textbox = new System.Windows.Forms.TextBox();
            this.btn_find_user = new System.Windows.Forms.Button();
            this.dtgv_privs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_privs)).BeginInit();
            this.SuspendLayout();
            // 
            // grant_label
            // 
            this.grant_label.AutoSize = true;
            this.grant_label.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grant_label.Location = new System.Drawing.Point(10, 100);
            this.grant_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grant_label.Name = "grant_label";
            this.grant_label.Size = new System.Drawing.Size(178, 23);
            this.grant_label.TabIndex = 1;
            this.grant_label.Text = "GRANT PRIVILEGE";
            // 
            // grant_to_label
            // 
            this.grant_to_label.AutoSize = true;
            this.grant_to_label.Location = new System.Drawing.Point(10, 140);
            this.grant_to_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grant_to_label.Name = "grant_to_label";
            this.grant_to_label.Size = new System.Drawing.Size(75, 17);
            this.grant_to_label.TabIndex = 1;
            this.grant_to_label.Text = "User/Role:";
            // 
            // grant_to_textbox
            // 
            this.grant_to_textbox.Location = new System.Drawing.Point(90, 138);
            this.grant_to_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.grant_to_textbox.Name = "grant_to_textbox";
            this.grant_to_textbox.Size = new System.Drawing.Size(200, 22);
            this.grant_to_textbox.TabIndex = 2;
            this.grant_to_textbox.TextChanged += new System.EventHandler(this.grantTo_textbox_TextChanged);
            // 
            // grant_privs_label
            // 
            this.grant_privs_label.AutoSize = true;
            this.grant_privs_label.Location = new System.Drawing.Point(10, 170);
            this.grant_privs_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grant_privs_label.Name = "grant_privs_label";
            this.grant_privs_label.Size = new System.Drawing.Size(66, 17);
            this.grant_privs_label.TabIndex = 1;
            this.grant_privs_label.Text = "Privilege:";
            // 
            // grant_privs_textbox
            // 
            this.grant_privs_textbox.Location = new System.Drawing.Point(90, 168);
            this.grant_privs_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.grant_privs_textbox.Name = "grant_privs_textbox";
            this.grant_privs_textbox.Size = new System.Drawing.Size(200, 22);
            this.grant_privs_textbox.TabIndex = 2;
            this.grant_privs_textbox.TextChanged += new System.EventHandler(this.grantPrivs_textbox_TextChanged);
            // 
            // admin_option
            // 
            this.admin_option.Location = new System.Drawing.Point(180, 200);
            this.admin_option.Name = "admin_option";
            this.admin_option.Size = new System.Drawing.Size(120, 20);
            this.admin_option.TabIndex = 2;
            this.admin_option.Text = "Admin option";
            this.admin_option.CheckedChanged += new System.EventHandler(this.admin_option_CheckedChanged);
            // 
            // btn_grant_privs
            // 
            this.btn_grant_privs.Location = new System.Drawing.Point(75, 240);
            this.btn_grant_privs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_grant_privs.Name = "btn_grant_privs";
            this.btn_grant_privs.Size = new System.Drawing.Size(150, 28);
            this.btn_grant_privs.TabIndex = 4;
            this.btn_grant_privs.Text = "Grant privilege";
            this.btn_grant_privs.UseVisualStyleBackColor = true;
            this.btn_grant_privs.Click += new System.EventHandler(this.btn_grantPrivs_Click);
            // 
            // revoke_label
            // 
            this.revoke_label.AutoSize = true;
            this.revoke_label.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revoke_label.Location = new System.Drawing.Point(10, 340);
            this.revoke_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revoke_label.Name = "revoke_label";
            this.revoke_label.Size = new System.Drawing.Size(186, 23);
            this.revoke_label.TabIndex = 1;
            this.revoke_label.Text = "REVOKE PRIVILEGE";
            // 
            // revoke_from_label
            // 
            this.revoke_from_label.AutoSize = true;
            this.revoke_from_label.Location = new System.Drawing.Point(10, 380);
            this.revoke_from_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revoke_from_label.Name = "revoke_from_label";
            this.revoke_from_label.Size = new System.Drawing.Size(75, 17);
            this.revoke_from_label.TabIndex = 1;
            this.revoke_from_label.Text = "User/Role:";
            // 
            // revoke_from_textbox
            // 
            this.revoke_from_textbox.Location = new System.Drawing.Point(90, 378);
            this.revoke_from_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.revoke_from_textbox.Name = "revoke_from_textbox";
            this.revoke_from_textbox.Size = new System.Drawing.Size(200, 22);
            this.revoke_from_textbox.TabIndex = 2;
            this.revoke_from_textbox.TextChanged += new System.EventHandler(this.revokeFrom_textbox_TextChanged);
            // 
            // revoke_privs_label
            // 
            this.revoke_privs_label.AutoSize = true;
            this.revoke_privs_label.Location = new System.Drawing.Point(10, 410);
            this.revoke_privs_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revoke_privs_label.Name = "revoke_privs_label";
            this.revoke_privs_label.Size = new System.Drawing.Size(66, 17);
            this.revoke_privs_label.TabIndex = 1;
            this.revoke_privs_label.Text = "Privilege:";
            // 
            // revoke_privs_textbox
            // 
            this.revoke_privs_textbox.Location = new System.Drawing.Point(90, 408);
            this.revoke_privs_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.revoke_privs_textbox.Name = "revoke_privs_textbox";
            this.revoke_privs_textbox.Size = new System.Drawing.Size(200, 22);
            this.revoke_privs_textbox.TabIndex = 2;
            this.revoke_privs_textbox.TextChanged += new System.EventHandler(this.revokePrivs_textbox_TextChanged);
            // 
            // btn_revoke_privs
            // 
            this.btn_revoke_privs.Location = new System.Drawing.Point(75, 450);
            this.btn_revoke_privs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_revoke_privs.Name = "btn_revoke_privs";
            this.btn_revoke_privs.Size = new System.Drawing.Size(150, 28);
            this.btn_revoke_privs.TabIndex = 4;
            this.btn_revoke_privs.Text = "Revoke privilege";
            this.btn_revoke_privs.UseVisualStyleBackColor = true;
            this.btn_revoke_privs.Click += new System.EventHandler(this.btn_revokePrivs_Click);
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Location = new System.Drawing.Point(500, 20);
            this.role_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(41, 17);
            this.role_label.TabIndex = 1;
            this.role_label.Text = "Role:";
            // 
            // role_textbox
            // 
            this.role_textbox.Location = new System.Drawing.Point(550, 15);
            this.role_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.role_textbox.Name = "role_textbox";
            this.role_textbox.Size = new System.Drawing.Size(300, 22);
            this.role_textbox.TabIndex = 2;
            this.role_textbox.TextChanged += new System.EventHandler(this.role_textbox_TextChanged);
            // 
            // btn_find_role
            // 
            this.btn_find_role.Location = new System.Drawing.Point(880, 12);
            this.btn_find_role.Margin = new System.Windows.Forms.Padding(4);
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
            this.user_label.Location = new System.Drawing.Point(500, 60);
            this.user_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(42, 17);
            this.user_label.TabIndex = 1;
            this.user_label.Text = "User:";
            // 
            // user_textbox
            // 
            this.user_textbox.Location = new System.Drawing.Point(550, 55);
            this.user_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.user_textbox.Name = "user_textbox";
            this.user_textbox.Size = new System.Drawing.Size(300, 22);
            this.user_textbox.TabIndex = 2;
            this.user_textbox.TextChanged += new System.EventHandler(this.user_textbox_TextChanged);
            // 
            // btn_find_user
            // 
            this.btn_find_user.Location = new System.Drawing.Point(880, 52);
            this.btn_find_user.Margin = new System.Windows.Forms.Padding(4);
            this.btn_find_user.Name = "btn_find_user";
            this.btn_find_user.Size = new System.Drawing.Size(100, 28);
            this.btn_find_user.TabIndex = 4;
            this.btn_find_user.Text = "Find User";
            this.btn_find_user.UseVisualStyleBackColor = true;
            this.btn_find_user.Click += new System.EventHandler(this.btn_findUser_Click);
            // 
            // dtgv_privs
            // 
            this.dtgv_privs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_privs.Location = new System.Drawing.Point(300, 100);
            this.dtgv_privs.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_privs.Name = "dtgv_privs";
            this.dtgv_privs.RowHeadersWidth = 51;
            this.dtgv_privs.Size = new System.Drawing.Size(750, 420);
            this.dtgv_privs.TabIndex = 1;
            // 
            // PrivilegeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grant_label);
            this.Controls.Add(this.grant_to_label);
            this.Controls.Add(this.grant_to_textbox);
            this.Controls.Add(this.grant_privs_label);
            this.Controls.Add(this.grant_privs_textbox);
            this.Controls.Add(this.admin_option);
            this.Controls.Add(this.btn_grant_privs);
            this.Controls.Add(this.revoke_label);
            this.Controls.Add(this.revoke_from_label);
            this.Controls.Add(this.revoke_from_textbox);
            this.Controls.Add(this.revoke_privs_label);
            this.Controls.Add(this.revoke_privs_textbox);
            this.Controls.Add(this.btn_revoke_privs);
            this.Controls.Add(this.dtgv_privs);
            this.Controls.Add(this.role_label);
            this.Controls.Add(this.role_textbox);
            this.Controls.Add(this.btn_find_role);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.user_textbox);
            this.Controls.Add(this.btn_find_user);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrivilegeManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrivilegeManage";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_privs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grant_label;
        private System.Windows.Forms.Label grant_to_label;
        private System.Windows.Forms.TextBox grant_to_textbox;
        private System.Windows.Forms.Label grant_privs_label;
        private System.Windows.Forms.TextBox grant_privs_textbox;
        private System.Windows.Forms.CheckBox admin_option;
        private System.Windows.Forms.Button btn_grant_privs;

        private System.Windows.Forms.Label revoke_label;
        private System.Windows.Forms.Label revoke_from_label;
        private System.Windows.Forms.TextBox revoke_from_textbox;
        private System.Windows.Forms.Label revoke_privs_label;
        private System.Windows.Forms.TextBox revoke_privs_textbox;
        private System.Windows.Forms.Button btn_revoke_privs;

        private System.Windows.Forms.DataGridView dtgv_privs;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.TextBox role_textbox;
        private System.Windows.Forms.Button btn_find_role;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.TextBox user_textbox;
        private System.Windows.Forms.Button btn_find_user;
    }
}