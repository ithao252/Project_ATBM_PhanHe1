namespace ATBM_N08
{
    partial class TableManage
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
            this.table_name_label = new System.Windows.Forms.Label();
            this.table_name_textbox = new System.Windows.Forms.TextBox();
            this.btn_find_table = new System.Windows.Forms.Button();
            this.btn_drop_table = new System.Windows.Forms.Button();
            this.dtgv_table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // table_name_label
            // 
            this.table_name_label.AutoSize = true;
            this.table_name_label.Location = new System.Drawing.Point(28, 25);
            this.table_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.table_name_label.Name = "table_name_label";
            this.table_name_label.Size = new System.Drawing.Size(87, 17);
            this.table_name_label.TabIndex = 1;
            this.table_name_label.Text = "Table name:";
            // 
            // table_name_textbox
            // 
            this.table_name_textbox.Location = new System.Drawing.Point(136, 21);
            this.table_name_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.table_name_textbox.Name = "table_name_textbox";
            this.table_name_textbox.Size = new System.Drawing.Size(408, 22);
            this.table_name_textbox.TabIndex = 2;
            this.table_name_textbox.TextChanged += new System.EventHandler(this.table_name_textbox_TextChanged);
            // 
            // btn_find_table
            // 
            this.btn_find_table.Location = new System.Drawing.Point(573, 18);
            this.btn_find_table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_find_table.Name = "btn_find_table";
            this.btn_find_table.Size = new System.Drawing.Size(100, 28);
            this.btn_find_table.TabIndex = 4;
            this.btn_find_table.Text = "Find";
            this.btn_find_table.UseVisualStyleBackColor = true;
            this.btn_find_table.Click += new System.EventHandler(this.btn_findTable_Click);
            // 
            // btn_drop_table
            // 
            this.btn_drop_table.Location = new System.Drawing.Point(820, 18);
            this.btn_drop_table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_drop_table.Name = "btn_drop_table";
            this.btn_drop_table.Size = new System.Drawing.Size(200, 28);
            this.btn_drop_table.TabIndex = 4;
            this.btn_drop_table.Text = "DROP THIS TABLE";
            this.btn_drop_table.UseVisualStyleBackColor = true;
            this.btn_drop_table.Click += new System.EventHandler(this.btn_dropTable_Click);
            // 
            // dtgv_table
            // 
            this.dtgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_table.Location = new System.Drawing.Point(16, 65);
            this.dtgv_table.Name = "dtgv_table";
            this.dtgv_table.Size = new System.Drawing.Size(1029, 474);
            this.dtgv_table.TabIndex = 5;
            // 
            // TableManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgv_table);
            this.Controls.Add(this.btn_find_table);
            this.Controls.Add(this.btn_drop_table);
            this.Controls.Add(this.table_name_textbox);
            this.Controls.Add(this.table_name_label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TableManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManage";
/*            this.Load += new System.EventHandler(this.TableManage_Load);
*/            ((System.ComponentModel.ISupportInitialize)(this.dtgv_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label table_name_label;
        private System.Windows.Forms.TextBox table_name_textbox;
        private System.Windows.Forms.Button btn_find_table;
        private System.Windows.Forms.Button btn_drop_table;
        private System.Windows.Forms.DataGridView dtgv_table;
    }
}