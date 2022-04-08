namespace ATBM_N08
{
    partial class createRole
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
            this.btn_withoutpass = new System.Windows.Forms.CheckBox();
            this.btn_createRole = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Role = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_withoutpass
            // 
            this.btn_withoutpass.AutoSize = true;
            this.btn_withoutpass.Location = new System.Drawing.Point(471, 97);
            this.btn_withoutpass.Name = "btn_withoutpass";
            this.btn_withoutpass.Size = new System.Drawing.Size(210, 29);
            this.btn_withoutpass.TabIndex = 10;
            this.btn_withoutpass.Text = "without password";
            this.btn_withoutpass.UseVisualStyleBackColor = true;
            this.btn_withoutpass.CheckedChanged += new System.EventHandler(this.btn_withoutpass_CheckedChanged);
            // 
            // btn_createRole
            // 
            this.btn_createRole.Location = new System.Drawing.Point(274, 166);
            this.btn_createRole.Name = "btn_createRole";
            this.btn_createRole.Size = new System.Drawing.Size(166, 44);
            this.btn_createRole.TabIndex = 11;
            this.btn_createRole.Text = "Create Role";
            this.btn_createRole.UseVisualStyleBackColor = true;
            this.btn_createRole.Click += new System.EventHandler(this.btn_createRole_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txbPass);
            this.panel1.Controls.Add(this.lb_Password);
            this.panel1.Controls.Add(this.lb_Role);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(33, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(408, 110);
            this.panel1.TabIndex = 12;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(130, 69);
            this.txbPass.Margin = new System.Windows.Forms.Padding(6);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '•';
            this.txbPass.Size = new System.Drawing.Size(256, 31);
            this.txbPass.TabIndex = 1;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(6, 71);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(112, 25);
            this.lb_Password.TabIndex = 0;
            this.lb_Password.Text = "Password:";
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(130, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 31);
            this.textBox1.TabIndex = 1;
            // 
            // createRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 230);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_createRole);
            this.Controls.Add(this.btn_withoutpass);
            this.Name = "createRole";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Role";
            this.Load += new System.EventHandler(this.createRole_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox btn_withoutpass;
        private System.Windows.Forms.Button btn_createRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.TextBox textBox1;
    }
}