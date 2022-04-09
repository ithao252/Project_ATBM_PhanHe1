namespace ATBM_N08
{
    partial class updateRole
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
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Role = new System.Windows.Forms.Label();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.btn_updateRole = new System.Windows.Forms.Button();
            this.cb_withoutpass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbNewPass);
            this.panel1.Controls.Add(this.lb_Password);
            this.panel1.Controls.Add(this.lb_Role);
            this.panel1.Controls.Add(this.tbRole);
            this.panel1.Location = new System.Drawing.Point(33, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(408, 110);
            this.panel1.TabIndex = 15;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(130, 69);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(6);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '•';
            this.tbNewPass.Size = new System.Drawing.Size(256, 31);
            this.tbNewPass.TabIndex = 1;
            this.tbNewPass.TextChanged += new System.EventHandler(this.tbNewPass_TextChanged);
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(6, 71);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(114, 25);
            this.lb_Password.TabIndex = 0;
            this.lb_Password.Text = "New Pass:";
            // 
            // lb_Role
            // 
            this.lb_Role.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Role.AutoSize = true;
            this.lb_Role.Location = new System.Drawing.Point(6, 21);
            this.lb_Role.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(62, 25);
            this.lb_Role.TabIndex = 0;
            this.lb_Role.Text = "Role:";
            // 
            // tbRole
            // 
            this.tbRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRole.Location = new System.Drawing.Point(130, 18);
            this.tbRole.Margin = new System.Windows.Forms.Padding(6);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(256, 31);
            this.tbRole.TabIndex = 1;
            // 
            // btn_updateRole
            // 
            this.btn_updateRole.Location = new System.Drawing.Point(253, 163);
            this.btn_updateRole.Name = "btn_updateRole";
            this.btn_updateRole.Size = new System.Drawing.Size(208, 44);
            this.btn_updateRole.TabIndex = 14;
            this.btn_updateRole.Text = "Change password";
            this.btn_updateRole.UseVisualStyleBackColor = true;
            this.btn_updateRole.Click += new System.EventHandler(this.btn_updateRole_Click);
            // 
            // cb_withoutpass
            // 
            this.cb_withoutpass.AutoSize = true;
            this.cb_withoutpass.Location = new System.Drawing.Point(471, 94);
            this.cb_withoutpass.Name = "cb_withoutpass";
            this.cb_withoutpass.Size = new System.Drawing.Size(210, 29);
            this.cb_withoutpass.TabIndex = 13;
            this.cb_withoutpass.Text = "without password";
            this.cb_withoutpass.UseVisualStyleBackColor = true;
            this.cb_withoutpass.CheckedChanged += new System.EventHandler(this.cb_withoutpass_CheckedChanged);
            // 
            // updateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 230);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_updateRole);
            this.Controls.Add(this.cb_withoutpass);
            this.Name = "updateRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change role\'s password";
            this.Load += new System.EventHandler(this.updateRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Button btn_updateRole;
        private System.Windows.Forms.CheckBox cb_withoutpass;
    }
}