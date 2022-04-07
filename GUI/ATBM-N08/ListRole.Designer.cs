namespace ATBM_N08
{
    partial class ListRole
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
            this.dtgv_ListUser = new System.Windows.Forms.DataGridView();
            this.btn_createRole = new System.Windows.Forms.Button();
            this.btn_updateRole = new System.Windows.Forms.Button();
            this.btn_deleteRole = new System.Windows.Forms.Button();
            this.btn_grant_revokeRole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ListUser
            // 
            this.dtgv_ListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListUser.Location = new System.Drawing.Point(4, 71);
            this.dtgv_ListUser.Margin = new System.Windows.Forms.Padding(6);
            this.dtgv_ListUser.Name = "dtgv_ListUser";
            this.dtgv_ListUser.RowHeadersWidth = 82;
            this.dtgv_ListUser.Size = new System.Drawing.Size(1420, 723);
            this.dtgv_ListUser.TabIndex = 7;
            this.dtgv_ListUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListUser_CellContentClick);
            // 
            // btn_createRole
            // 
            this.btn_createRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_createRole.FlatAppearance.BorderSize = 0;
            this.btn_createRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createRole.ForeColor = System.Drawing.Color.White;
            this.btn_createRole.Location = new System.Drawing.Point(49, 15);
            this.btn_createRole.Margin = new System.Windows.Forms.Padding(6);
            this.btn_createRole.Name = "btn_createRole";
            this.btn_createRole.Size = new System.Drawing.Size(242, 50);
            this.btn_createRole.TabIndex = 8;
            this.btn_createRole.Text = "CREATE";
            this.btn_createRole.UseVisualStyleBackColor = false;
            this.btn_createRole.Click += new System.EventHandler(this.btn_createRole_Click);
            // 
            // btn_updateRole
            // 
            this.btn_updateRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_updateRole.FlatAppearance.BorderSize = 0;
            this.btn_updateRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateRole.ForeColor = System.Drawing.Color.White;
            this.btn_updateRole.Location = new System.Drawing.Point(390, 15);
            this.btn_updateRole.Margin = new System.Windows.Forms.Padding(6);
            this.btn_updateRole.Name = "btn_updateRole";
            this.btn_updateRole.Size = new System.Drawing.Size(242, 50);
            this.btn_updateRole.TabIndex = 9;
            this.btn_updateRole.Text = "UPDATE";
            this.btn_updateRole.UseVisualStyleBackColor = false;
            this.btn_updateRole.Click += new System.EventHandler(this.btn_updateRole_Click);
            // 
            // btn_deleteRole
            // 
            this.btn_deleteRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_deleteRole.FlatAppearance.BorderSize = 0;
            this.btn_deleteRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRole.ForeColor = System.Drawing.Color.White;
            this.btn_deleteRole.Location = new System.Drawing.Point(741, 15);
            this.btn_deleteRole.Margin = new System.Windows.Forms.Padding(6);
            this.btn_deleteRole.Name = "btn_deleteRole";
            this.btn_deleteRole.Size = new System.Drawing.Size(242, 50);
            this.btn_deleteRole.TabIndex = 10;
            this.btn_deleteRole.Text = "DELETE";
            this.btn_deleteRole.UseVisualStyleBackColor = false;
            this.btn_deleteRole.Click += new System.EventHandler(this.btn_deleteRole_Click);
            // 
            // btn_grant_revokeRole
            // 
            this.btn_grant_revokeRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_grant_revokeRole.FlatAppearance.BorderSize = 0;
            this.btn_grant_revokeRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grant_revokeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grant_revokeRole.ForeColor = System.Drawing.Color.White;
            this.btn_grant_revokeRole.Location = new System.Drawing.Point(1078, 15);
            this.btn_grant_revokeRole.Margin = new System.Windows.Forms.Padding(6);
            this.btn_grant_revokeRole.Name = "btn_grant_revokeRole";
            this.btn_grant_revokeRole.Size = new System.Drawing.Size(302, 50);
            this.btn_grant_revokeRole.TabIndex = 11;
            this.btn_grant_revokeRole.Text = "GRANT/REVOKE";
            this.btn_grant_revokeRole.UseVisualStyleBackColor = false;
            this.btn_grant_revokeRole.Click += new System.EventHandler(this.btn_grant_revokeRole_Click);
            // 
            // ListRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 802);
            this.Controls.Add(this.btn_grant_revokeRole);
            this.Controls.Add(this.btn_deleteRole);
            this.Controls.Add(this.btn_updateRole);
            this.Controls.Add(this.btn_createRole);
            this.Controls.Add(this.dtgv_ListUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ListRole";
            this.Text = "ds";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ListUser;
        private System.Windows.Forms.Button btn_createRole;
        private System.Windows.Forms.Button btn_updateRole;
        private System.Windows.Forms.Button btn_deleteRole;
        private System.Windows.Forms.Button btn_grant_revokeRole;
    }
}