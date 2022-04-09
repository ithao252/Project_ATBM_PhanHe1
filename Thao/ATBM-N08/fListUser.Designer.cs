namespace ATBM_N08
{
    partial class fListUser
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
            this.dtgv_User = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.userPrivilege_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_User)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_User
            // 
            this.dtgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_User.Location = new System.Drawing.Point(0, 34);
            this.dtgv_User.Name = "dtgv_User";
            this.dtgv_User.Size = new System.Drawing.Size(712, 378);
            this.dtgv_User.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(174, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(152, 26);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "CREATE NEW USER";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(23, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(145, 26);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "UPDATE USER";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // userPrivilege_btn
            // 
            this.userPrivilege_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.userPrivilege_btn.FlatAppearance.BorderSize = 0;
            this.userPrivilege_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userPrivilege_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPrivilege_btn.ForeColor = System.Drawing.Color.White;
            this.userPrivilege_btn.Location = new System.Drawing.Point(332, 2);
            this.userPrivilege_btn.Name = "userPrivilege_btn";
            this.userPrivilege_btn.Size = new System.Drawing.Size(222, 26);
            this.userPrivilege_btn.TabIndex = 11;
            this.userPrivilege_btn.Text = "CHECK PRIVILEGE OF USER";
            this.userPrivilege_btn.UseVisualStyleBackColor = false;
            this.userPrivilege_btn.Click += new System.EventHandler(this.userPrivilege_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(560, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "CHECK ROLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userPrivilege_btn);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtgv_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fListUser";
            this.Text = "fListUser";
            this.Load += new System.EventHandler(this.fListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_User;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button userPrivilege_btn;
        private System.Windows.Forms.Button button1;
    }
}