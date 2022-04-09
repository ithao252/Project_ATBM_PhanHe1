namespace ATBM_N08
{
    partial class deleteRole
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
            this.lb_Role = new System.Windows.Forms.Label();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.btn_deleteRole = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lb_Role);
            this.panel1.Controls.Add(this.tbRole);
            this.panel1.Location = new System.Drawing.Point(152, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(410, 64);
            this.panel1.TabIndex = 15;
            // 
            // lb_Role
            // 
            this.lb_Role.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Role.AutoSize = true;
            this.lb_Role.Location = new System.Drawing.Point(26, 19);
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
            this.tbRole.Location = new System.Drawing.Point(112, 16);
            this.tbRole.Margin = new System.Windows.Forms.Padding(6);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(268, 31);
            this.tbRole.TabIndex = 1;
            // 
            // btn_deleteRole
            // 
            this.btn_deleteRole.Location = new System.Drawing.Point(274, 139);
            this.btn_deleteRole.Name = "btn_deleteRole";
            this.btn_deleteRole.Size = new System.Drawing.Size(166, 44);
            this.btn_deleteRole.TabIndex = 14;
            this.btn_deleteRole.Text = "Delete Role";
            this.btn_deleteRole.UseVisualStyleBackColor = true;
            this.btn_deleteRole.Click += new System.EventHandler(this.btn_deleteRole_Click);
            // 
            // deleteRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 230);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_deleteRole);
            this.Name = "deleteRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Role";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Button btn_deleteRole;
    }
}