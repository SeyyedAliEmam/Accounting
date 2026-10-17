namespace Accounting.App.Customers_Form
{
    partial class Form_Customers
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Button_Join = new System.Windows.Forms.ToolStripButton();
            this.Button_Edit = new System.Windows.Forms.ToolStripButton();
            this.Button_Delete = new System.Windows.Forms.ToolStripButton();
            this.Button_Refresh = new System.Windows.Forms.ToolStripButton();
            this.Label_Search = new System.Windows.Forms.ToolStripLabel();
            this.TextBox_Search = new System.Windows.Forms.ToolStripTextBox();
            this.DataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Join,
            this.Button_Edit,
            this.Button_Delete,
            this.Button_Refresh,
            this.Label_Search,
            this.TextBox_Search});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Button_Join
            // 
            this.Button_Join.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.Button_Join.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_Join.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Join.Name = "Button_Join";
            this.Button_Join.Size = new System.Drawing.Size(102, 64);
            this.Button_Join.Text = "افزودن شخص";
            this.Button_Join.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_Join.Click += new System.EventHandler(this.Button_Join_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.Button_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(105, 64);
            this.Button_Edit.Text = "ویرایش شخص";
            this.Button_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.Button_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(91, 64);
            this.Button_Delete.Text = "حذف شخص";
            this.Button_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Image = global::Accounting.App.Properties.Resources._1371476394_refresh_red;
            this.Button_Refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(76, 64);
            this.Button_Refresh.Text = "بروزرسانی";
            this.Button_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Label_Search
            // 
            this.Label_Search.Name = "Label_Search";
            this.Label_Search.Size = new System.Drawing.Size(60, 64);
            this.Label_Search.Text = "جستجو :";
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(100, 67);
            this.TextBox_Search.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // DataGridView_Customers
            // 
            this.DataGridView_Customers.AllowUserToAddRows = false;
            this.DataGridView_Customers.AllowUserToDeleteRows = false;
            this.DataGridView_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.FullName,
            this.Phone,
            this.Addres});
            this.DataGridView_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Customers.Location = new System.Drawing.Point(0, 67);
            this.DataGridView_Customers.Name = "DataGridView_Customers";
            this.DataGridView_Customers.ReadOnly = true;
            this.DataGridView_Customers.RowHeadersWidth = 51;
            this.DataGridView_Customers.RowTemplate.Height = 24;
            this.DataGridView_Customers.Size = new System.Drawing.Size(582, 286);
            this.DataGridView_Customers.TabIndex = 1;
            // 
            // Customer_ID
            // 
            this.Customer_ID.DataPropertyName = "CustomerID";
            this.Customer_ID.HeaderText = "کد شخص";
            this.Customer_ID.MinimumWidth = 6;
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "شماره تلفن";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Addres
            // 
            this.Addres.DataPropertyName = "Addres";
            this.Addres.HeaderText = "آدرس";
            this.Addres.MinimumWidth = 6;
            this.Addres.Name = "Addres";
            this.Addres.ReadOnly = true;
            // 
            // Form_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.DataGridView_Customers);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Customers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات اشخاص";
            this.Load += new System.EventHandler(this.Form_Customers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Button_Join;
        private System.Windows.Forms.ToolStripButton Button_Edit;
        private System.Windows.Forms.ToolStripButton Button_Delete;
        private System.Windows.Forms.ToolStripButton Button_Refresh;
        private System.Windows.Forms.ToolStripLabel Label_Search;
        private System.Windows.Forms.ToolStripTextBox TextBox_Search;
        private System.Windows.Forms.DataGridView DataGridView_Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addres;
    }
}