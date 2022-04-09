namespace ATBM_N08
{
    partial class AddTable
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
            this.btn_create_table = new System.Windows.Forms.Button();
            this.dtgv_table = new System.Windows.Forms.DataGridView();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Primary_key = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // table_name_label
            // 
            this.table_name_label.AutoSize = true;
            this.table_name_label.Location = new System.Drawing.Point(200, 20);
            this.table_name_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.table_name_label.Name = "table_name_label";
            this.table_name_label.Size = new System.Drawing.Size(90, 20);
            this.table_name_label.TabIndex = 1;
            this.table_name_label.Text = "Table name:";
            // 
            // table_name_textbox
            // 
            this.table_name_textbox.Location = new System.Drawing.Point(300, 18);
            this.table_name_textbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.table_name_textbox.Name = "table_name_textbox";
            this.table_name_textbox.Size = new System.Drawing.Size(250, 20);
            this.table_name_textbox.TabIndex = 2;
            this.table_name_textbox.TextChanged += new System.EventHandler(this.table_name_textbox_TextChanged);
            // 
            // btn_create_table
            // 
            this.btn_create_table.Location = new System.Drawing.Point(580, 15);
            this.btn_create_table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_create_table.Name = "btn_create_table";
            this.btn_create_table.Size = new System.Drawing.Size(100, 28);
            this.btn_create_table.TabIndex = 4;
            this.btn_create_table.Text = "Create";
            this.btn_create_table.UseVisualStyleBackColor = true;
            this.btn_create_table.Click += new System.EventHandler(this.btn_create_table_Click);
            // 
            // dtgv_table
            // 
            this.dtgv_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_name,
            this.Data_type,
            this.Data_size,
            this.Nullable,
            this.Primary_key});
            this.dtgv_table.Location = new System.Drawing.Point(16, 65);
            this.dtgv_table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv_table.Name = "dtgv_table";
            this.dtgv_table.RowHeadersWidth = 51;
            this.dtgv_table.Size = new System.Drawing.Size(1029, 474);
            this.dtgv_table.TabIndex = 5;
            this.dtgv_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_table_CellContentClick_1);
            // 
            // Column_name
            // 
            this.Column_name.HeaderText = "Column name";
            this.Column_name.MinimumWidth = 6;
            this.Column_name.Name = "Column_name";
            // 
            // Data_type
            // 
            this.Data_type.HeaderText = "Data type";
            this.Data_type.MinimumWidth = 6;
            this.Data_type.Name = "Data_type";
            // 
            // Data_size
            // 
            this.Data_size.HeaderText = "Data size";
            this.Data_size.MinimumWidth = 6;
            this.Data_size.Name = "Data_size";
            // 
            // Nullable
            // 
            this.Nullable.HeaderText = "Nullable";
            this.Nullable.MinimumWidth = 6;
            this.Nullable.Name = "Nullable";
            // 
            // Primary_key
            // 
            this.Primary_key.HeaderText = "Primary key";
            this.Primary_key.MinimumWidth = 6;
            this.Primary_key.Name = "Primary_key";
            // 
            // TableManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtgv_table);
            this.Controls.Add(this.btn_create_table);
            this.Controls.Add(this.table_name_label);
            this.Controls.Add(this.table_name_textbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTable";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label table_name_label;
        private System.Windows.Forms.TextBox table_name_textbox;
        private System.Windows.Forms.Button btn_create_table;
        private System.Windows.Forms.DataGridView dtgv_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_size;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nullable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Primary_key;
    }
}