using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Repository;
using Accounting.App.Customers_Form;
using Accounting.App.Accounting_Form;
using Accounting.App.Report_Form;
using Accounting.Utility.Convertor;
using Acccounting.App;
using Accounting.ViewModels.Accounting;
using Accounting.Business;


namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login form_login = new Form_Login();
            if (form_login.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                Label_Date.Text = DateTime.Now.ToShamsi().ToString();
                Label_Time.Text = DateTime.Now.ToString("HH,mm,ss");
                Month_report();
            }
            else
            {
                Application.Exit();
            }
        }

        private void Button_Customers_Click(object sender, EventArgs e)
        {
            Form_Customers form_Customers = new Form_Customers();
            form_Customers.ShowDialog();
        }

        private void Button_Accounting_Click(object sender, EventArgs e)
        {
            Form_Accounting form_Accounting = new Form_Accounting();
            form_Accounting.ShowDialog();
        }

        private void Button_PayReport_Click(object sender, EventArgs e)
        {
            Form_PayReport form_PayReport = new Form_PayReport();
            form_PayReport.TypeID = 2;
            form_PayReport.ShowDialog();
        }

        private void Button_ReciveReport_Click(object sender, EventArgs e)
        {
            Form_PayReport form_PayReport = new Form_PayReport();
            form_PayReport.TypeID = 1;
            form_PayReport.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Label_Time.Text = DateTime.Now.ToString("HH,mm,ss");
        }

        private void Button_EnterOptions_Click(object sender, EventArgs e)
        {
            Form_Login form_login = new Form_Login();
            form_login.IsEdit = true;
            form_login.ShowDialog();

        }

        void Month_report()
        {
            ReportViewModel month_report = Account.Month_account();
            Label_Pay.Text = month_report.Pay.ToString("#,0");
            Label_Recive.Text = month_report.Recive.ToString("#,0");
            Label_mande.Text = month_report.mande.ToString("#,0");
        }
    }
}
