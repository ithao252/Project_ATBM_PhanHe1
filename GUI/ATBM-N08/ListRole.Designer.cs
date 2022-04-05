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
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ListUser
            // 
            this.dtgv_ListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListUser.Location = new System.Drawing.Point(2, 37);
            this.dtgv_ListUser.Name = "dtgv_ListUser";
            this.dtgv_ListUser.Size = new System.Drawing.Size(710, 376);
            this.dtgv_ListUser.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(249, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(152, 26);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "CREATE NEW ROLE";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // ListRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 416);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtgv_ListUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListRole";
            this.Text = "ListRole";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ListUser;
        private System.Windows.Forms.Button btn_add;
    }
}