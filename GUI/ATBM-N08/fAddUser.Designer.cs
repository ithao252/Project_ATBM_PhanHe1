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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Username);
            this.panel1.Controls.Add(this.txtbUsername);
            this.panel1.Location = new System.Drawing.Point(24, 19);
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
            this.txtbUsername.TextChanged += new System.EventHandler(this.txtbUsername_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Password);
            this.panel2.Controls.Add(this.txtbPass);
            this.panel2.Location = new System.Drawing.Point(24, 100);
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
            this.btn_CreateUser.Location = new System.Drawing.Point(36, 181);
            this.btn_CreateUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(372, 54);
            this.btn_CreateUser.TabIndex = 5;
            this.btn_CreateUser.Text = "Tạo mới";
            this.btn_CreateUser.UseVisualStyleBackColor = false;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // fAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 256);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.Button btn_CreateUser;
    }
}