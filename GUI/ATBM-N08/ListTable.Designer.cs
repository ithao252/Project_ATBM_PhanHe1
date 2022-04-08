﻿namespace ATBM_N08
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
            this.table_owner_label = new System.Windows.Forms.Label();
            this.table_owner_textbox = new System.Windows.Forms.TextBox();
            this.btn_find_tableOwner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // table_owner_label
            // 
            this.table_owner_label.AutoSize = true;
            this.table_owner_label.Location = new System.Drawing.Point(380, 10);
            this.table_owner_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.table_owner_label.Name = "table_owner_label";
            this.table_owner_label.Size = new System.Drawing.Size(87, 17);
            this.table_owner_label.TabIndex = 1;
            this.table_owner_label.Text = "Table owner:";
            // 
            // table_owner_textbox
            // 
            this.table_owner_textbox.Location = new System.Drawing.Point(450, 10);
            this.table_owner_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.table_owner_textbox.Name = "table_owner_textbox";
            this.table_owner_textbox.Size = new System.Drawing.Size(200, 22);
            this.table_owner_textbox.TabIndex = 2;
            this.table_owner_textbox.TextChanged += new System.EventHandler(this.table_owner_textbox_TextChanged);
            // 
            // btn_find_tableOwner
            // 
            this.btn_find_tableOwner.Location = new System.Drawing.Point(650, 5);
            this.btn_find_tableOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_find_tableOwner.Name = "btn_find_tableOwner";
            this.btn_find_tableOwner.Size = new System.Drawing.Size(50, 28);
            this.btn_find_tableOwner.TabIndex = 4;
            this.btn_find_tableOwner.Text = "Find";
            this.btn_find_tableOwner.UseVisualStyleBackColor = true;
            this.btn_find_tableOwner.Click += new System.EventHandler(this.btn_findTableOwner_Click);
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
            this.btn_add_table.Location = new System.Drawing.Point(10, 5);
            this.btn_add_table.Name = "btn_add_table";
            this.btn_add_table.Size = new System.Drawing.Size(120, 26);
            this.btn_add_table.TabIndex = 5;
            this.btn_add_table.Text = "CREATE TABLE";
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
            this.btn_detail_table.Location = new System.Drawing.Point(140, 5);
            this.btn_detail_table.Name = "btn_detail_table";
            this.btn_detail_table.Size = new System.Drawing.Size(200, 26);
            this.btn_detail_table.TabIndex = 5;
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
            this.Controls.Add(this.btn_find_tableOwner);
            this.Controls.Add(this.table_owner_textbox);
            this.Controls.Add(this.table_owner_label);
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
        private System.Windows.Forms.Label table_owner_label;
        private System.Windows.Forms.TextBox table_owner_textbox;
        private System.Windows.Forms.Button btn_find_tableOwner;
    }
}