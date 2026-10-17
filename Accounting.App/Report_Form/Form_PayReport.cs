using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.App.Accounting_Form;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Customers;

namespace Accounting.App.Report_Form
{
    public partial class Form_PayReport : Form
    {
        public int TypeID = 0;
        public Form_PayReport()
        {
            InitializeComponent();
        }

        private void Form_PayReport_Load(object sender, EventArgs e)
        {
            using(Unitofwork DB = new Unitofwork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel() { CustomerID = 0, FullName = "انتخاب کنید" });
                list.AddRange(DB.CustomerRepository.GetCustomersFullName());

                ComboBox_Customer.DataSource = list ;
                //منبع اطلاعات کمبو باکس لیست باشد
                ComboBox_Customer.DisplayMember= "FullName";
                //آیتم های انتخابی 
                ComboBox_Customer.ValueMember = "CustomerID";
                //گرفتن داده مورد نظر پس از انتخاب
            }

            if (TypeID == 1)
            {
                this.Text = "گزارش دریافت";
            }
            else
            {
                this.Text = "گزارش پرداخت";
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        void Search()
        {
            using (Unitofwork DB = new Unitofwork())
            {
                List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();
                DateTime? Time1;
                //علامت سوال به معنای نال پذیر بودن این متغیر است
                DateTime? Time2;

                if (Convert.ToInt32(ComboBox_Customer.SelectedValue) != 0)
                {
                    int customerid = Convert.ToInt32(ComboBox_Customer.SelectedValue.ToString());
                    result.AddRange(DB.AccountingRepository.Get(a => a.TypeID == TypeID && a.CustomerID == customerid));
                }
                else
                {
                    result.AddRange(DB.AccountingRepository.Get(a => a.TypeID == TypeID));
                }

                if (TextBox_Time1.Text != "    /  /")
                {
                    Time1 = Convert.ToDateTime(TextBox_Time1.Text);
                    //Time1 = DateConvertor.ToMiladi(Time1.Value);
                    result = result.Where(r => r.DateTime >= Time1.Value).ToList();
                }
                if (TextBox_Time2.Text != "    /  /")
                {
                    Time2 = Convert.ToDateTime(TextBox_Time2.Text);
                    //Time2 = DateConvertor.ToMiladi(Time2.Value);
                    result = result.Where(r => r.DateTime <= Time2.Value).ToList();
                }

                DataGridView_Report.Rows.Clear();
                foreach (var accounting in result)
                {
                    string CustomerFullName = DB.CustomerRepository.GetFullNameByID(accounting.CustomerID);
                    DataGridView_Report.Rows.Add(accounting.AccountingID ,CustomerFullName, accounting.Amount,accounting.DateTime.ToShamsi(),accounting.Description);
                }
            }

        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (DataGridView_Report.CurrentRow != null)
            {
                int id = int.Parse(DataGridView_Report.CurrentRow.Cells[0].Value.ToString());
                if(RtlMessageBox.Show("آیا از حذف اطمینان دارید ؟" ,"هشدار",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using(Unitofwork DB = new Unitofwork())
                    {
                        DB.AccountingRepository.Delete(id);
                        DB.Save();
                        Search();
                    }
                }
            }
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            if (DataGridView_Report.CurrentRow != null)
            {
                int id = int.Parse(DataGridView_Report.CurrentRow.Cells[0].Value.ToString());
                Form_Accounting editform = new Form_Accounting();
                editform.AccountID = id;
                if(editform.ShowDialog() == DialogResult.OK) 
                {
                    Search();
                }
            }
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            DataTable Print = new DataTable();
            Print.Columns.Add("Customer");
            Print.Columns.Add("Amount");
            Print.Columns.Add("DateTime");
            Print.Columns.Add("Description");
            foreach (DataGridViewRow item in DataGridView_Report.Rows)
            {
                Print.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    );
            }
            STI_Print.Load(Application.StartupPath + "/Report.mrt"); 
            STI_Print.RegData("Dt",Print);
            STI_Print.Show();
        }

    }
}
