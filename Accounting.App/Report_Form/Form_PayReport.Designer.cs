namespace Accounting.App.Report_Form
{
    partial class Form_PayReport
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
            this.Button_Edit = new System.Windows.Forms.ToolStripButton();
            this.Button_Delete = new System.Windows.Forms.ToolStripButton();
            this.Button_Refresh = new System.Windows.Forms.ToolStripButton();
            this.Button_Print = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.TextBox_Time2 = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_Time1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_Customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView_Report = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STI_Print = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Edit,
            this.Button_Delete,
            this.Button_Refresh,
            this.Button_Print});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(597, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Button_Edit
            // 
            this.Button_Edit.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.Button_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(59, 64);
            this.Button_Edit.Text = "ویرایش";
            this.Button_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.Button_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(45, 64);
            this.Button_Delete.Text = "حذف";
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
            // Button_Print
            // 
            this.Button_Print.Image = global::Accounting.App.Properties.Resources._1371476193_printers___Faxes;
            this.Button_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(44, 64);
            this.Button_Print.Text = "چاپ";
            this.Button_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Search);
            this.groupBox1.Controls.Add(this.TextBox_Time2);
            this.groupBox1.Controls.Add(this.TextBox_Time1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBox_Customer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(597, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(21, 28);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(72, 45);
            this.Button_Search.TabIndex = 6;
            this.Button_Search.Text = "جستجو";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // TextBox_Time2
            // 
            this.TextBox_Time2.Location = new System.Drawing.Point(113, 54);
            this.TextBox_Time2.Mask = "0000/00/00";
            this.TextBox_Time2.Name = "TextBox_Time2";
            this.TextBox_Time2.Size = new System.Drawing.Size(142, 23);
            this.TextBox_Time2.TabIndex = 5;
            this.TextBox_Time2.ValidatingType = typeof(System.DateTime);
            // 
            // TextBox_Time1
            // 
            this.TextBox_Time1.Location = new System.Drawing.Point(113, 22);
            this.TextBox_Time1.Mask = "0000/00/00";
            this.TextBox_Time1.Name = "TextBox_Time1";
            this.TextBox_Time1.Size = new System.Drawing.Size(142, 23);
            this.TextBox_Time1.TabIndex = 4;
            this.TextBox_Time1.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "تا تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "از تاریخ :";
            // 
            // ComboBox_Customer
            // 
            this.ComboBox_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Customer.FormattingEnabled = true;
            this.ComboBox_Customer.Location = new System.Drawing.Point(344, 37);
            this.ComboBox_Customer.Name = "ComboBox_Customer";
            this.ComboBox_Customer.Size = new System.Drawing.Size(138, 24);
            this.ComboBox_Customer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "شخص مورد نظر :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridView_Report);
            this.groupBox2.Location = new System.Drawing.Point(0, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 234);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست تراکنش ها";
            // 
            // DataGridView_Report
            // 
            this.DataGridView_Report.AllowUserToAddRows = false;
            this.DataGridView_Report.AllowUserToDeleteRows = false;
            this.DataGridView_Report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Customers,
            this.Amount,
            this.DateTime,
            this.Description});
            this.DataGridView_Report.Location = new System.Drawing.Point(0, 22);
            this.DataGridView_Report.Name = "DataGridView_Report";
            this.DataGridView_Report.ReadOnly = true;
            this.DataGridView_Report.RowHeadersWidth = 51;
            this.DataGridView_Report.RowTemplate.Height = 24;
            this.DataGridView_Report.Size = new System.Drawing.Size(597, 212);
            this.DataGridView_Report.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "AccountingID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Customers
            // 
            this.Customers.DataPropertyName = "CustomerID";
            this.Customers.HeaderText = "اشخاص";
            this.Customers.MinimumWidth = 6;
            this.Customers.Name = "Customers";
            this.Customers.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "مبلغ";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.HeaderText = "تاریخ ";
            this.DateTime.MinimumWidth = 6;
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // STI_Print
            // 
            this.STI_Print.CookieContainer = null;
            this.STI_Print.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.STI_Print.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.STI_Print.ReportAlias = "Report";
            this.STI_Print.ReportGuid = "28e856e8bc7244e99beb72411aac78f7";
            this.STI_Print.ReportName = "Report";
            this.STI_Print.ReportSource = null;
            this.STI_Print.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.STI_Print.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.STI_Print.UseProgressInThread = false;
            // 
            // Form_PayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_PayReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form_PayReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Button_Edit;
        private System.Windows.Forms.ToolStripButton Button_Delete;
        private System.Windows.Forms.ToolStripButton Button_Refresh;
        private System.Windows.Forms.ToolStripButton Button_Print;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.MaskedTextBox TextBox_Time2;
        private System.Windows.Forms.MaskedTextBox TextBox_Time1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridView_Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private Stimulsoft.Report.StiReport STI_Print;
    }
}