namespace Accounting.App.Customers_Form
{
    partial class Form_JoinandEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_JoinandEdit));
            this.GroupBox_Image = new System.Windows.Forms.GroupBox();
            this.Button_Image = new System.Windows.Forms.Button();
            this.CustomerPC_Image = new System.Windows.Forms.PictureBox();
            this.GroupBox_FullName = new System.Windows.Forms.GroupBox();
            this.TextBox_FullName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox_Phone = new System.Windows.Forms.GroupBox();
            this.TextBox_Phone = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.GroupBox_Addres = new System.Windows.Forms.GroupBox();
            this.TextBox_Addres = new System.Windows.Forms.TextBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Validator_FullName = new ValidationComponents.RequiredFieldValidator(this.components);
            this.Validator_Phone = new ValidationComponents.RequiredFieldValidator(this.components);
            this.GroupBox_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPC_Image)).BeginInit();
            this.GroupBox_FullName.SuspendLayout();
            this.GroupBox_Phone.SuspendLayout();
            this.GroupBox_Addres.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Image
            // 
            this.GroupBox_Image.Controls.Add(this.Button_Image);
            this.GroupBox_Image.Controls.Add(this.CustomerPC_Image);
            this.GroupBox_Image.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Image.Name = "GroupBox_Image";
            this.GroupBox_Image.Size = new System.Drawing.Size(194, 242);
            this.GroupBox_Image.TabIndex = 0;
            this.GroupBox_Image.TabStop = false;
            this.GroupBox_Image.Text = "تصویر";
            // 
            // Button_Image
            // 
            this.Button_Image.Location = new System.Drawing.Point(6, 201);
            this.Button_Image.Name = "Button_Image";
            this.Button_Image.Size = new System.Drawing.Size(182, 29);
            this.Button_Image.TabIndex = 1;
            this.Button_Image.Text = "انتخاب تصویر";
            this.Button_Image.UseVisualStyleBackColor = true;
            this.Button_Image.Click += new System.EventHandler(this.Button_Image_Click);
            // 
            // CustomerPC_Image
            // 
            this.CustomerPC_Image.Image = global::Acccounting.App.Properties.Resources.bbc5b0e0_6df9_11ef_bf81_6b527db09a25;
            this.CustomerPC_Image.Location = new System.Drawing.Point(6, 22);
            this.CustomerPC_Image.Name = "CustomerPC_Image";
            this.CustomerPC_Image.Size = new System.Drawing.Size(182, 173);
            this.CustomerPC_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerPC_Image.TabIndex = 0;
            this.CustomerPC_Image.TabStop = false;
            // 
            // GroupBox_FullName
            // 
            this.GroupBox_FullName.Controls.Add(this.TextBox_FullName);
            this.GroupBox_FullName.Controls.Add(this.groupBox3);
            this.GroupBox_FullName.Location = new System.Drawing.Point(212, 12);
            this.GroupBox_FullName.Name = "GroupBox_FullName";
            this.GroupBox_FullName.Size = new System.Drawing.Size(258, 60);
            this.GroupBox_FullName.TabIndex = 1;
            this.GroupBox_FullName.TabStop = false;
            this.GroupBox_FullName.Text = "نام و نام خانوادگی";
            // 
            // TextBox_FullName
            // 
            this.TextBox_FullName.Location = new System.Drawing.Point(6, 22);
            this.TextBox_FullName.Name = "TextBox_FullName";
            this.TextBox_FullName.Size = new System.Drawing.Size(229, 23);
            this.TextBox_FullName.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // GroupBox_Phone
            // 
            this.GroupBox_Phone.Controls.Add(this.TextBox_Phone);
            this.GroupBox_Phone.Controls.Add(this.groupBox5);
            this.GroupBox_Phone.Location = new System.Drawing.Point(212, 78);
            this.GroupBox_Phone.Name = "GroupBox_Phone";
            this.GroupBox_Phone.Size = new System.Drawing.Size(258, 58);
            this.GroupBox_Phone.TabIndex = 3;
            this.GroupBox_Phone.TabStop = false;
            this.GroupBox_Phone.Text = "شماره تلفن";
            // 
            // TextBox_Phone
            // 
            this.TextBox_Phone.Location = new System.Drawing.Point(6, 22);
            this.TextBox_Phone.Name = "TextBox_Phone";
            this.TextBox_Phone.Size = new System.Drawing.Size(229, 23);
            this.TextBox_Phone.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(0, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 96);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // GroupBox_Addres
            // 
            this.GroupBox_Addres.Controls.Add(this.TextBox_Addres);
            this.GroupBox_Addres.Location = new System.Drawing.Point(212, 142);
            this.GroupBox_Addres.Name = "GroupBox_Addres";
            this.GroupBox_Addres.Size = new System.Drawing.Size(258, 112);
            this.GroupBox_Addres.TabIndex = 4;
            this.GroupBox_Addres.TabStop = false;
            this.GroupBox_Addres.Text = "آدرس";
            // 
            // TextBox_Addres
            // 
            this.TextBox_Addres.Location = new System.Drawing.Point(6, 27);
            this.TextBox_Addres.Multiline = true;
            this.TextBox_Addres.Name = "TextBox_Addres";
            this.TextBox_Addres.Size = new System.Drawing.Size(229, 73);
            this.TextBox_Addres.TabIndex = 4;
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(381, 260);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(89, 36);
            this.Button_OK.TabIndex = 5;
            this.Button_OK.Text = "ثبت";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Validator_FullName
            // 
            this.Validator_FullName.CancelFocusChangeWhenInvalid = false;
            this.Validator_FullName.ControlToValidate = this.TextBox_FullName;
            this.Validator_FullName.ErrorMessage = "لطفا نام و نام خانوادگی خود را وارد کنید";
            this.Validator_FullName.Icon = ((System.Drawing.Icon)(resources.GetObject("Validator_FullName.Icon")));
            // 
            // Validator_Phone
            // 
            this.Validator_Phone.CancelFocusChangeWhenInvalid = false;
            this.Validator_Phone.ControlToValidate = this.TextBox_Phone;
            this.Validator_Phone.ErrorMessage = "لطفا شماره تلفن را وارد کنید";
            this.Validator_Phone.Icon = ((System.Drawing.Icon)(resources.GetObject("Validator_Phone.Icon")));
            // 
            // Form_JoinandEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GroupBox_Addres);
            this.Controls.Add(this.GroupBox_Phone);
            this.Controls.Add(this.GroupBox_FullName);
            this.Controls.Add(this.GroupBox_Image);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_JoinandEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن شخص";
            this.Load += new System.EventHandler(this.Form_JoinandEdit_Load);
            this.GroupBox_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPC_Image)).EndInit();
            this.GroupBox_FullName.ResumeLayout(false);
            this.GroupBox_FullName.PerformLayout();
            this.GroupBox_Phone.ResumeLayout(false);
            this.GroupBox_Phone.PerformLayout();
            this.GroupBox_Addres.ResumeLayout(false);
            this.GroupBox_Addres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Image;
        private System.Windows.Forms.GroupBox GroupBox_FullName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox GroupBox_Phone;
        private System.Windows.Forms.TextBox TextBox_FullName;
        private System.Windows.Forms.TextBox TextBox_Phone;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox GroupBox_Addres;
        private System.Windows.Forms.TextBox TextBox_Addres;
        private System.Windows.Forms.Button Button_Image;
        private System.Windows.Forms.PictureBox CustomerPC_Image;
        private System.Windows.Forms.Button Button_OK;
        private ValidationComponents.RequiredFieldValidator Validator_FullName;
        private ValidationComponents.RequiredFieldValidator Validator_Phone;
    }
}