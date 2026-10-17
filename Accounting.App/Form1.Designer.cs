namespace Accounting.App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.Button_EnterOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Button_Customers = new System.Windows.Forms.ToolStripButton();
            this.Button_Accounting = new System.Windows.Forms.ToolStripButton();
            this.Button_PayReport = new System.Windows.Forms.ToolStripButton();
            this.Button_ReciveReport = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Label_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.Label_Recive = new System.Windows.Forms.Label();
            this.Label_Pay = new System.Windows.Forms.Label();
            this.Label_mande = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DropDownButton
            // 
            this.DropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_EnterOptions});
            this.DropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButton.Image")));
            this.DropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownButton.Name = "DropDownButton";
            this.DropDownButton.Size = new System.Drawing.Size(78, 24);
            this.DropDownButton.Text = "تنظیمات";
            // 
            // Button_EnterOptions
            // 
            this.Button_EnterOptions.Name = "Button_EnterOptions";
            this.Button_EnterOptions.Size = new System.Drawing.Size(266, 26);
            this.Button_EnterOptions.Text = "تغییر نام کاربری یا کلمه عبور";
            this.Button_EnterOptions.Click += new System.EventHandler(this.Button_EnterOptions_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Customers,
            this.Button_Accounting,
            this.Button_PayReport,
            this.Button_ReciveReport});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(782, 67);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Button_Customers
            // 
            this.Button_Customers.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.Button_Customers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_Customers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Customers.Name = "Button_Customers";
            this.Button_Customers.Size = new System.Drawing.Size(63, 64);
            this.Button_Customers.Text = "اشخاص";
            this.Button_Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_Customers.Click += new System.EventHandler(this.Button_Customers_Click);
            // 
            // Button_Accounting
            // 
            this.Button_Accounting.Image = global::Accounting.App.Properties.Resources.list2;
            this.Button_Accounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_Accounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Accounting.Name = "Button_Accounting";
            this.Button_Accounting.Size = new System.Drawing.Size(92, 64);
            this.Button_Accounting.Text = "تراکنش جدید";
            this.Button_Accounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_Accounting.ToolTipText = "تراکنش";
            this.Button_Accounting.Click += new System.EventHandler(this.Button_Accounting_Click);
            // 
            // Button_PayReport
            // 
            this.Button_PayReport.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.Button_PayReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_PayReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_PayReport.Name = "Button_PayReport";
            this.Button_PayReport.Size = new System.Drawing.Size(102, 64);
            this.Button_PayReport.Text = "گزارش پرداخت";
            this.Button_PayReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_PayReport.Click += new System.EventHandler(this.Button_PayReport_Click);
            // 
            // Button_ReciveReport
            // 
            this.Button_ReciveReport.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.Button_ReciveReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Button_ReciveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_ReciveReport.Name = "Button_ReciveReport";
            this.Button_ReciveReport.Size = new System.Drawing.Size(103, 64);
            this.Button_ReciveReport.Text = "گزارش دریافت";
            this.Button_ReciveReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_ReciveReport.Click += new System.EventHandler(this.Button_ReciveReport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label_Date,
            this.Label_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Label_Date
            // 
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(151, 20);
            this.Label_Date.Text = "toolStripStatusLabel1";
            // 
            // Label_Time
            // 
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(151, 20);
            this.Label_Time.Text = "toolStripStatusLabel2";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "دریافت ها :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "پرداخت ها :";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(683, 95);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(74, 16);
            this.Label.TabIndex = 5;
            this.Label.Text = "باقی مانده :";
            // 
            // Label_Recive
            // 
            this.Label_Recive.Location = new System.Drawing.Point(397, 32);
            this.Label_Recive.Name = "Label_Recive";
            this.Label_Recive.Size = new System.Drawing.Size(268, 16);
            this.Label_Recive.TabIndex = 6;
            this.Label_Recive.Text = "0";
            // 
            // Label_Pay
            // 
            this.Label_Pay.Location = new System.Drawing.Point(397, 64);
            this.Label_Pay.Name = "Label_Pay";
            this.Label_Pay.Size = new System.Drawing.Size(268, 16);
            this.Label_Pay.TabIndex = 7;
            this.Label_Pay.Text = "0";
            // 
            // Label_mande
            // 
            this.Label_mande.Location = new System.Drawing.Point(397, 95);
            this.Label_mande.Name = "Label_mande";
            this.Label_mande.Size = new System.Drawing.Size(268, 16);
            this.Label_mande.TabIndex = 8;
            this.Label_mande.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label_mande);
            this.groupBox1.Controls.Add(this.Label_Recive);
            this.groupBox1.Controls.Add(this.Label_Pay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش این ماه ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton DropDownButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Button_Customers;
        private System.Windows.Forms.ToolStripButton Button_Accounting;
        private System.Windows.Forms.ToolStripButton Button_PayReport;
        private System.Windows.Forms.ToolStripButton Button_ReciveReport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Label_Date;
        private System.Windows.Forms.ToolStripStatusLabel Label_Time;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem Button_EnterOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Label_Recive;
        private System.Windows.Forms.Label Label_Pay;
        private System.Windows.Forms.Label Label_mande;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

