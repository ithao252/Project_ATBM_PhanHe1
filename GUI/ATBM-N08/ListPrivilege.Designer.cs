namespace ATBM_N08
{
    partial class ListPrivilege
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
            this.dtgv_Privilege = new System.Windows.Forms.DataGridView();
            this.btn_manage_Privilege = new System.Windows.Forms.Button();
            this.btn_role_Privilege = new System.Windows.Forms.Button();
            this.btn_user_Privilege = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Privilege)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Privilege
            // 
            this.dtgv_Privilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Privilege.Location = new System.Drawing.Point(0, 34);
            this.dtgv_Privilege.Name = "dtgv_Privilege";
            this.dtgv_Privilege.Size = new System.Drawing.Size(712, 378);
            this.dtgv_Privilege.TabIndex = 0;
            // 
            // btn_manage_Privilege
            // 
            this.btn_manage_Privilege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_manage_Privilege.FlatAppearance.BorderSize = 0;
            this.btn_manage_Privilege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_Privilege.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_Privilege.ForeColor = System.Drawing.Color.White;
            this.btn_manage_Privilege.Location = new System.Drawing.Point(50, 5);
            this.btn_manage_Privilege.Name = "btn_manage_Privilege";
            this.btn_manage_Privilege.Size = new System.Drawing.Size(200, 26);
            this.btn_manage_Privilege.TabIndex = 5;
            this.btn_manage_Privilege.Text = "MANAGE PRIVILEGES";
            this.btn_manage_Privilege.UseVisualStyleBackColor = false;
            this.btn_manage_Privilege.Click += new System.EventHandler(this.btn_managePrivilege_Click);
            // 
            // btn_role_Privilege
            // 
            this.btn_role_Privilege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_role_Privilege.FlatAppearance.BorderSize = 0;
            this.btn_role_Privilege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_role_Privilege.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_role_Privilege.ForeColor = System.Drawing.Color.White;
            this.btn_role_Privilege.Location = new System.Drawing.Point(500, 5);
            this.btn_role_Privilege.Name = "btn_role_Privilege";
            this.btn_role_Privilege.Size = new System.Drawing.Size(80, 26);
            this.btn_role_Privilege.TabIndex = 5;
            this.btn_role_Privilege.Text = "ROLE";
            this.btn_role_Privilege.UseVisualStyleBackColor = false;
            this.btn_role_Privilege.Click += new System.EventHandler(this.btn_rolePrivilege_Click);
            // 
            // btn_user_Privilege
            // 
            this.btn_user_Privilege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_user_Privilege.FlatAppearance.BorderSize = 0;
            this.btn_user_Privilege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_Privilege.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_Privilege.ForeColor = System.Drawing.Color.White;
            this.btn_user_Privilege.Location = new System.Drawing.Point(600, 5);
            this.btn_user_Privilege.Name = "btn_user_Privilege";
            this.btn_user_Privilege.Size = new System.Drawing.Size(80, 26);
            this.btn_user_Privilege.TabIndex = 5;
            this.btn_user_Privilege.Text = "USER";
            this.btn_user_Privilege.UseVisualStyleBackColor = false;
            this.btn_user_Privilege.Click += new System.EventHandler(this.btn_userPrivilege_Click);
            // 
            // ListPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 417);
            this.Controls.Add(this.btn_manage_Privilege);
            this.Controls.Add(this.btn_role_Privilege);
            this.Controls.Add(this.btn_user_Privilege);
            this.Controls.Add(this.dtgv_Privilege);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListPrivilege";
            this.Text = "ListPrivilege";
            this.Load += new System.EventHandler(this.ListPrivilege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Privilege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Privilege;
        private System.Windows.Forms.Button btn_manage_Privilege;
        private System.Windows.Forms.Button btn_role_Privilege;
        private System.Windows.Forms.Button btn_user_Privilege;
    }
}