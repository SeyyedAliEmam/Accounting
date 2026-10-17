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
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using Accounting.DataLayer;
using ValidationComponents;
using System.IO;

namespace Accounting.App.Accounting_Form
{
    public partial class Form_Accounting : Form
    {
        public int AccountID = 0;
        public Form_Accounting()
        {
            InitializeComponent();
        }
        private void Form_Accounting_Load(object sender, EventArgs e)
        {
            using(Unitofwork DB = new Unitofwork())
            {
                DataGridView_Customers.AutoGenerateColumns = false;
                DataGridView_Customers.DataSource = DB.CustomerRepository.GetCustomersFullName();
                //متد گت کاستومر فول نیم رو ایجاد کردیم تا تنها دادی ای که از پایگاه واکشی میشه رکورد های نام افراد باشه
                //و رکورد های دیگه بیخودی واکشی نشن چون بهشون نیاز نداریم 
                if (AccountID != 0)
                {
                    this.Text = "ویرایش گزارش";
                    Button_OK.Text = "ویرایش";
                    var account = DB.AccountingRepository.GetByID(AccountID);
                    Numeric_Amount.Text = account.Amount.ToString();
                    TextBox_Description.Text = account.Description;
                    TextBox_FullName.Text = DB.CustomerRepository.GetFullNameByID(account.CustomerID);
                    if (account.TypeID == 1)
                    {
                        RadioButton_Recive.Checked = true;
                    }
                    if (account.TypeID == 2)
                    {
                        RadioButton_Pay.Checked = true;
                    }
                }
            }
        }

        private void Search_Customers_TextChanged(object sender, EventArgs e)
        {
            using(Unitofwork DB = new Unitofwork())
            {
                DataGridView_Customers.AutoGenerateColumns = false;
                DataGridView_Customers.DataSource = DB.CustomerRepository.GetCustomersFullName(Search_Customers.Text);
            }
        }

        private void DataGridView_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_FullName.Text = DataGridView_Customers.CurrentRow.Cells[1].Value.ToString(); 
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            using (Unitofwork DB = new Unitofwork())
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (RadioButton_Pay.Checked || RadioButton_Recive.Checked)
                    {
                        DataLayer.Accounting accounting = new DataLayer.Accounting();
                        accounting.Amount = Convert.ToInt32(Numeric_Amount.Value.ToString());
                        accounting.CustomerID = DB.CustomerRepository.GetIDByFullName(TextBox_FullName.Text);
                        accounting.TypeID = (RadioButton_Recive.Checked) ? 1 : 2;
                        //علامت سوال به معنای ایف و دو نقطه به معنای الس برای شرط روی دستور داخل پرانتز است
                        accounting.DateTime = DateTime.Now;
                        accounting.Description = TextBox_Description.Text;
                        if (AccountID == 0)
                        {
                            DB.AccountingRepository.Insert(accounting);
                        }
                        else
                        {
                            accounting.AccountingID = AccountID;
                            DB.AccountingRepository.Update(accounting);
                        }
                        DB.Save();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
                    }
                }
            }
        }
    }
}
