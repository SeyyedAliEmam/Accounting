using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using Accounting.DataLayer;
using System.IO;

namespace Accounting.App.Customers_Form
{
    public partial class Form_JoinandEdit : Form
    {
        public int customerid = 0;
        //Unitofwork DB = new Unitofwork();
        public Form_JoinandEdit()
        {
            InitializeComponent();
        }

        private void Form_JoinandEdit_Load(object sender, EventArgs e)
        {
            using(Unitofwork DB = new Unitofwork())
            {
                if (customerid != 0)
                {
                    this.Text = "ویرایش اطلاعات";
                    Button_OK.Text = "ویرایش";
                    var customer = DB.CustomerRepository.GetCustomer(customerid);
                    TextBox_FullName.Text = customer.FullName;
                    TextBox_Phone.Text = customer.Phone;
                    TextBox_Addres.Text = customer.Addres;
                    CustomerPC_Image.ImageLocation = Application.StartupPath + "/Images/" + customer.Image;
                }
            }
        }

        private void Button_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                CustomerPC_Image.ImageLocation = openfile.FileName;
            }
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            using (Unitofwork DB = new Unitofwork())
            {
                if (BaseValidator.IsFormValid(this.components))
                //اگر کامپوننت های اعتبار سنجی ارور ندهند
                {
                    string imageName = Guid.NewGuid().ToString() + Path.GetExtension(CustomerPC_Image.ImageLocation);
                    string path = Application.StartupPath + "/Images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    CustomerPC_Image.Image.Save(path + imageName);

                    Customers Customer = new Customers();
                    Customer.FullName = TextBox_FullName.Text;
                    Customer.Phone = TextBox_Phone.Text;
                    Customer.Addres = TextBox_Addres.Text;
                    Customer.Image = imageName;
                             
                    if (customerid == 0)
                    {
                        DB.CustomerRepository.InsertCustomer(Customer);
                    }
                    else
                    {
                        Customer.CustomerID = customerid;             
                        DB.CustomerRepository.UpdateCustomer(Customer);
                    }

                    DB.Save();
                    DialogResult = DialogResult.OK;
                }
            }
        }

    }
}
