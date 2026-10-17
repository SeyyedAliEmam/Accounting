using Accounting.DataLayer.Context;
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

namespace Accounting.App
{
    public partial class Form_Login : Form
    {
        public bool IsEdit = false;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Text = "تغییر نام کاربری یا رمز ورود";
                Button_Enter.Text = "ذخیره";
                using (Unitofwork DB = new Unitofwork())
                {
                    var login = DB.LoginRepository.Get().First();
                    TextBox_UserName.Text = login.UserName;
                    TextBox_Password.Text = login.Password;
                }
            }
        }

        private void Button_Enter_Click(object sender, EventArgs e)
        {
            if  (BaseValidator.IsFormValid(this.components))
            {
                if (IsEdit)
                {
                    using(Unitofwork DB = new Unitofwork())
                    {
                        var login = DB.LoginRepository.Get().First();
                        login.UserName = TextBox_UserName.Text;
                        login.Password = TextBox_Password.Text;
                        DB.LoginRepository.Update(login);
                        DB.Save();
                        Application.Restart();
                    }
                }
                else
                {
                    using (Unitofwork DB = new Unitofwork())
                    {
                        if (DB.LoginRepository.Get(l => l.UserName == TextBox_UserName.Text && l.Password == TextBox_Password.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("کاربری یافت نشد");
                        }
                    }
                }
            }
        }
    }
}
