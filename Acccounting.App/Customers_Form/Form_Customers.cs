using Accounting.DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Accounting.App.Customers_Form
{
    public partial class Form_Customers : Form
    {
        public Form_Customers()
        {
            InitializeComponent();
        }

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            TextBox_Search.Text= "";
            BindGrid();
        }

        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            using (Unitofwork DB = new Unitofwork())
            {
                DataGridView_Customers.DataSource = DB.CustomerRepository.GetCustomersBySearch(TextBox_Search.Text);
            }
        }

        void BindGrid()
        {
            using (Unitofwork DB = new Unitofwork())
            {
                DataGridView_Customers.AutoGenerateColumns= false;
                DataGridView_Customers.DataSource = DB.CustomerRepository.GetAllCustomers();
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (DataGridView_Customers.CurrentRow != null)
            {
                using (Unitofwork DB = new Unitofwork())
                {
                    string fullname = DataGridView_Customers.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {fullname} اطمینان دارید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int customerid = Convert.ToInt32(DataGridView_Customers.CurrentRow.Cells[0].Value.ToString());
                        DB.CustomerRepository.DeleteCustomer(customerid);
                        DB.Save();
                        BindGrid();
                    }
                }
            }

            else 
            {
               RtlMessageBox.Show("لطفا شخص مورد نظر را انتخاب کنید");                
            }
        }

        private void Button_Join_Click(object sender, EventArgs e)
        {
            Form_JoinandEdit form_JoinandEdit = new Form_JoinandEdit();
            if (form_JoinandEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            if (DataGridView_Customers.CurrentRow != null)
            {
                int customerid = Convert.ToInt32(DataGridView_Customers.CurrentRow.Cells[0].Value.ToString());
                Form_JoinandEdit form_JoinandEdit = new Form_JoinandEdit();
                form_JoinandEdit.customerid = customerid ;
                if (form_JoinandEdit.ShowDialog() == DialogResult.OK) 
                {
                    BindGrid();
                }
            }
        }
    }
}
