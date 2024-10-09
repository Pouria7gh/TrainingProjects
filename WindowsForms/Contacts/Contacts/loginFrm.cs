using Contacts.DataLayer.Convertors;
using Contacts.DataLayer.DTOs;
using Contacts.DataLayer.Entities;
using Contacts.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class loginFrm : Form
    {
        public loginFrm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((UserName.Text == string.Empty) || (Password.Text == string.Empty))
                {
                    MessageBox.Show("لطفا نام کاربری و کلمه عبور را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(UserName, "*");
                    errorProvider1.SetError(Password, "*");
                    UserName.Focus();
                }
                else
                {
                    UserService userService = new UserService();
                    UserViewModel UserVM = userService.Login(UserName.Text, MD5Hash.MD5Hashing(Password.Text));

                    if (UserVM.Password != null)
                    {
                        this.Hide();
                        CurrentUser.UserName = UserVM.UserName;
                        CurrentUser.Password = UserVM.Password;
                        CurrentUser.Role = UserVM.Role;
                        CurrentUser.Name = UserVM.Name;
                        CurrentUser.Family = UserVM.Family;
                        Main main = new Main();
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری و کلمه عبور صحیح نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.Show();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '●')
            {
                Hide.BringToFront();
                Password.PasswordChar = '\0';
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '\0')
            {
                Show.BringToFront();
                Password.PasswordChar = '●';
            }
        }
    }
}
