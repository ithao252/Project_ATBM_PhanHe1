namespace ATBM_N08
{
    partial class ListViews
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
            this.dtgv_Views = new System.Windows.Forms.DataGridView();
            this.view_owner_label = new System.Windows.Forms.Label();
            this.view_owner_textbox = new System.Windows.Forms.TextBox();
            this.btn_find_viewOwner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Views)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Views
            // 
            this.dtgv_Views.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Views.Location = new System.Drawing.Point(0, 65);
            this.dtgv_Views.Margin = new System.Windows.Forms.Padding(6);
            this.dtgv_Views.Name = "dtgv_Views";
            this.dtgv_Views.RowHeadersWidth = 82;
            this.dtgv_Views.Size = new System.Drawing.Size(1424, 727);
            this.dtgv_Views.TabIndex = 0;
            // 
            // view_owner_label
            // 
            this.view_owner_label.AutoSize = true;
            this.view_owner_label.Location = new System.Drawing.Point(52, 22);
            this.view_owner_label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.view_owner_label.Name = "view_owner_label";
            this.view_owner_label.Size = new System.Drawing.Size(128, 25);
            this.view_owner_label.TabIndex = 1;
            this.view_owner_label.Text = "View owner:";
            // 
            // view_owner_textbox
            // 
            this.view_owner_textbox.Location = new System.Drawing.Point(236, 22);
            this.view_owner_textbox.Margin = new System.Windows.Forms.Padding(8);
            this.view_owner_textbox.Name = "view_owner_textbox";
            this.view_owner_textbox.Size = new System.Drawing.Size(808, 31);
            this.view_owner_textbox.TabIndex = 2;
            this.view_owner_textbox.TextChanged += new System.EventHandler(this.view_owner_textbox_TextChanged);
            // 
            // btn_find_viewOwner
            // 
            this.btn_find_viewOwner.Location = new System.Drawing.Point(1072, 7);
            this.btn_find_viewOwner.Margin = new System.Windows.Forms.Padding(8);
            this.btn_find_viewOwner.Name = "btn_find_viewOwner";
            this.btn_find_viewOwner.Size = new System.Drawing.Size(100, 54);
            this.btn_find_viewOwner.TabIndex = 4;
            this.btn_find_viewOwner.Text = "Find";
            this.btn_find_viewOwner.UseVisualStyleBackColor = true;
            this.btn_find_viewOwner.Click += new System.EventHandler(this.btn_findViewOwner_Click);
            // 
            // ListViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 802);
            this.Controls.Add(this.dtgv_Views);
            this.Controls.Add(this.btn_find_viewOwner);
            this.Controls.Add(this.view_owner_textbox);
            this.Controls.Add(this.view_owner_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ListViews";
            this.Text = "ListTable";
            this.Load += new System.EventHandler(this.ListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Views)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Views;
        private System.Windows.Forms.Label view_owner_label;
        private System.Windows.Forms.TextBox view_owner_textbox;
        private System.Windows.Forms.Button btn_find_viewOwner;
    }
}