namespace ATBM_N08
{
    partial class GrantRevokeRole
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
            this.dtgv_RoleUser = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grant = new System.Windows.Forms.Label();
            this.commitGrant = new System.Windows.Forms.Button();
            this.tbRole1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.commitRevoke = new System.Windows.Forms.Button();
            this.tbRole2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_RoleUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_RoleUser
            // 
            this.dtgv_RoleUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_RoleUser.Location = new System.Drawing.Point(458, 23);
            this.dtgv_RoleUser.Margin = new System.Windows.Forms.Padding(6);
            this.dtgv_RoleUser.Name = "dtgv_RoleUser";
            this.dtgv_RoleUser.RowHeadersWidth = 82;
            this.dtgv_RoleUser.Size = new System.Drawing.Size(1118, 819);
            this.dtgv_RoleUser.TabIndex = 3;
            this.dtgv_RoleUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_RoleUser_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grant);
            this.panel1.Controls.Add(this.commitGrant);
            this.panel1.Controls.Add(this.tbRole1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbUser1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 267);
            this.panel1.TabIndex = 4;
            // 
            // grant
            // 
            this.grant.BackColor = System.Drawing.SystemColors.Desktop;
            this.grant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grant.Location = new System.Drawing.Point(0, 0);
            this.grant.Name = "grant";
            this.grant.Size = new System.Drawing.Size(385, 46);
            this.grant.TabIndex = 7;
            this.grant.Text = "Grant Role to User";
            this.grant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.grant.Click += new System.EventHandler(this.grant_Click);
            // 
            // commitGrant
            // 
            this.commitGrant.Location = new System.Drawing.Point(118, 199);
            this.commitGrant.Name = "commitGrant";
            this.commitGrant.Size = new System.Drawing.Size(131, 45);
            this.commitGrant.TabIndex = 6;
            this.commitGrant.Text = "COMMIT";
            this.commitGrant.UseVisualStyleBackColor = true;
            this.commitGrant.Click += new System.EventHandler(this.commitGrant_Click);
            // 
            // tbRole1
            // 
            this.tbRole1.Location = new System.Drawing.Point(118, 132);
            this.tbRole1.Name = "tbRole1";
            this.tbRole1.Size = new System.Drawing.Size(240, 31);
            this.tbRole1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Role:";
            // 
            // tbUser1
            // 
            this.tbUser1.Location = new System.Drawing.Point(118, 78);
            this.tbUser1.Name = "tbUser1";
            this.tbUser1.Size = new System.Drawing.Size(240, 31);
            this.tbUser1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.commitRevoke);
            this.panel2.Controls.Add(this.tbRole2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbUser2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(35, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 267);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "Revoke Role from User";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // commitRevoke
            // 
            this.commitRevoke.Location = new System.Drawing.Point(118, 199);
            this.commitRevoke.Name = "commitRevoke";
            this.commitRevoke.Size = new System.Drawing.Size(131, 45);
            this.commitRevoke.TabIndex = 6;
            this.commitRevoke.Text = "COMMIT";
            this.commitRevoke.UseVisualStyleBackColor = true;
            this.commitRevoke.Click += new System.EventHandler(this.commitRevoke_Click);
            // 
            // tbRole2
            // 
            this.tbRole2.Location = new System.Drawing.Point(118, 132);
            this.tbRole2.Name = "tbRole2";
            this.tbRole2.Size = new System.Drawing.Size(240, 31);
            this.tbRole2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role:";
            // 
            // tbUser2
            // 
            this.tbUser2.Location = new System.Drawing.Point(118, 78);
            this.tbUser2.Name = "tbUser2";
            this.tbUser2.Size = new System.Drawing.Size(240, 31);
            this.tbUser2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "User:";
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_reload.ForeColor = System.Drawing.Color.Snow;
            this.btn_reload.Location = new System.Drawing.Point(289, 767);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(131, 43);
            this.btn_reload.TabIndex = 6;
            this.btn_reload.Text = "Reload";
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // GrantRevokeRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 866);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_RoleUser);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GrantRevokeRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grant or Revoke Role";
            this.Load += new System.EventHandler(this.GrantRevokeRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_RoleUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_RoleUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser1;
        private System.Windows.Forms.Button commitGrant;
        private System.Windows.Forms.TextBox tbRole1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button commitRevoke;
        private System.Windows.Forms.TextBox tbRole2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label grant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reload;
    }
}