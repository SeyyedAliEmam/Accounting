namespace Accounting.App.Accounting_Form
{
    partial class Form_Accounting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Accounting));
            this.GroupBox_Customers = new System.Windows.Forms.GroupBox();
            this.Search_Customers = new System.Windows.Forms.TextBox();
            this.DataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_FullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioButton_Recive = new System.Windows.Forms.RadioButton();
            this.RadioButton_Pay = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Numeric_Amount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.RangeValidator_Amount = new ValidationComponents.RangeValidator(this.components);
            this.Validator_FullName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.GroupBox_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_Customers
            // 
            this.GroupBox_Customers.Controls.Add(this.Search_Customers);
            this.GroupBox_Customers.Controls.Add(this.DataGridView_Customers);
            this.GroupBox_Customers.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Customers.Name = "GroupBox_Customers";
            this.GroupBox_Customers.Size = new System.Drawing.Size(192, 329);
            this.GroupBox_Customers.TabIndex = 0;
            this.GroupBox_Customers.TabStop = false;
            this.GroupBox_Customers.Text = "اشخاص";
            // 
            // Search_Customers
            // 
            this.Search_Customers.Location = new System.Drawing.Point(6, 23);
            this.Search_Customers.Name = "Search_Customers";
            this.Search_Customers.Size = new System.Drawing.Size(180, 23);
            this.Search_Customers.TabIndex = 1;
            this.Search_Customers.TextChanged += new System.EventHandler(this.Search_Customers_TextChanged);
            // 
            // DataGridView_Customers
            // 
            this.DataGridView_Customers.AllowUserToAddRows = false;
            this.DataGridView_Customers.AllowUserToDeleteRows = false;
            this.DataGridView_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FullName});
            this.DataGridView_Customers.Location = new System.Drawing.Point(6, 52);
            this.DataGridView_Customers.Name = "DataGridView_Customers";
            this.DataGridView_Customers.ReadOnly = true;
            this.DataGridView_Customers.RowHeadersWidth = 51;
            this.DataGridView_Customers.RowTemplate.Height = 24;
            this.DataGridView_Customers.Size = new System.Drawing.Size(180, 271);
            this.DataGridView_Customers.TabIndex = 0;
            this.DataGridView_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Customers_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام ";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "شخص مورد نظر :";
            // 
            // TextBox_FullName
            // 
            this.TextBox_FullName.Location = new System.Drawing.Point(210, 12);
            this.TextBox_FullName.Name = "TextBox_FullName";
            this.TextBox_FullName.ReadOnly = true;
            this.TextBox_FullName.Size = new System.Drawing.Size(251, 23);
            this.TextBox_FullName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "نوع تراکنش :";
            // 
            // RadioButton_Recive
            // 
            this.RadioButton_Recive.AutoSize = true;
            this.RadioButton_Recive.Location = new System.Drawing.Point(397, 44);
            this.RadioButton_Recive.Name = "RadioButton_Recive";
            this.RadioButton_Recive.Size = new System.Drawing.Size(64, 20);
            this.RadioButton_Recive.TabIndex = 4;
            this.RadioButton_Recive.TabStop = true;
            this.RadioButton_Recive.Text = "دریافت";
            this.RadioButton_Recive.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Pay
            // 
            this.RadioButton_Pay.AutoSize = true;
            this.RadioButton_Pay.Location = new System.Drawing.Point(324, 44);
            this.RadioButton_Pay.Name = "RadioButton_Pay";
            this.RadioButton_Pay.Size = new System.Drawing.Size(67, 20);
            this.RadioButton_Pay.TabIndex = 5;
            this.RadioButton_Pay.TabStop = true;
            this.RadioButton_Pay.Text = "پرداخت";
            this.RadioButton_Pay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "مبلغ :";
            // 
            // Numeric_Amount
            // 
            this.Numeric_Amount.Location = new System.Drawing.Point(210, 76);
            this.Numeric_Amount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Numeric_Amount.Name = "Numeric_Amount";
            this.Numeric_Amount.Size = new System.Drawing.Size(251, 23);
            this.Numeric_Amount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "توضیحات :";
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Location = new System.Drawing.Point(210, 111);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(251, 224);
            this.TextBox_Description.TabIndex = 9;
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(467, 304);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(103, 31);
            this.Button_OK.TabIndex = 10;
            this.Button_OK.Text = "ثبت";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // RangeValidator_Amount
            // 
            this.RangeValidator_Amount.CancelFocusChangeWhenInvalid = false;
            this.RangeValidator_Amount.ControlToValidate = this.Numeric_Amount;
            this.RangeValidator_Amount.ErrorMessage = "مبلغ را وارد کنید";
            this.RangeValidator_Amount.Icon = ((System.Drawing.Icon)(resources.GetObject("RangeValidator_Amount.Icon")));
            this.RangeValidator_Amount.MaximumValue = "9999999999";
            this.RangeValidator_Amount.MinimumValue = "1";
            this.RangeValidator_Amount.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // Validator_FullName
            // 
            this.Validator_FullName.CancelFocusChangeWhenInvalid = false;
            this.Validator_FullName.ControlToValidate = this.TextBox_FullName;
            this.Validator_FullName.ErrorMessage = "شخص مورد نظر را انتخاب کنید";
            this.Validator_FullName.Icon = ((System.Drawing.Icon)(resources.GetObject("Validator_FullName.Icon")));
            // 
            // Form_Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.TextBox_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Numeric_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RadioButton_Pay);
            this.Controls.Add(this.RadioButton_Recive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_FullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox_Customers);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Accounting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.Form_Accounting_Load);
            this.GroupBox_Customers.ResumeLayout(false);
            this.GroupBox_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Customers;
        private System.Windows.Forms.TextBox Search_Customers;
        private System.Windows.Forms.DataGridView DataGridView_Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_FullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioButton_Recive;
        private System.Windows.Forms.RadioButton RadioButton_Pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Numeric_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.Button Button_OK;
        private ValidationComponents.RangeValidator RangeValidator_Amount;
        private ValidationComponents.RequiredFieldValidator Validator_FullName;
    }
}