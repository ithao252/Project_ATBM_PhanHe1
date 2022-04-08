namespace ATBM_N08
{
    partial class ListTable
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
            this.dtgv_Table = new System.Windows.Forms.DataGridView();
            this.btn_add_table = new System.Windows.Forms.Button();
            this.btn_detail_table = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Table
            // 
            this.dtgv_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Table.Location = new System.Drawing.Point(0, 34);
            this.dtgv_Table.Name = "dtgv_Table";
            this.dtgv_Table.Size = new System.Drawing.Size(712, 378);
            this.dtgv_Table.TabIndex = 0;
            // 
            // btn_add_table
            // 
            this.btn_add_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_add_table.FlatAppearance.BorderSize = 0;
            this.btn_add_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_table.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_table.ForeColor = System.Drawing.Color.White;
            this.btn_add_table.Location = new System.Drawing.Point(150, 2);
            this.btn_add_table.Name = "btn_add_table";
            this.btn_add_table.Size = new System.Drawing.Size(152, 26);
            this.btn_add_table.TabIndex = 9;
            this.btn_add_table.Text = "CREATE NEW TABLE";
            this.btn_add_table.UseVisualStyleBackColor = false;
            this.btn_add_table.Click += new System.EventHandler(this.btn_addTable_Click);
            // 
            // btn_detail_table
            // 
            this.btn_detail_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_detail_table.FlatAppearance.BorderSize = 0;
            this.btn_detail_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detail_table.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detail_table.ForeColor = System.Drawing.Color.White;
            this.btn_detail_table.Location = new System.Drawing.Point(400, 2);
            this.btn_detail_table.Name = "btn_detail_table";
            this.btn_detail_table.Size = new System.Drawing.Size(200, 26);
            this.btn_detail_table.TabIndex = 10;
            this.btn_detail_table.Text = "VIEW DETAILS OF TABLE";
            this.btn_detail_table.UseVisualStyleBackColor = false;
            this.btn_detail_table.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // ListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 417);
            this.Controls.Add(this.btn_add_table);
            this.Controls.Add(this.btn_detail_table);
            this.Controls.Add(this.dtgv_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListTable";
            this.Text = "ListTable";
            this.Load += new System.EventHandler(this.ListTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Table;
        private System.Windows.Forms.Button btn_add_table;
        private System.Windows.Forms.Button btn_detail_table;
    }
}