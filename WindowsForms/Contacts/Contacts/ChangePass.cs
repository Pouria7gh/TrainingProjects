using Contacts.DataLayer.Convertors;
using Contacts.DataLayer.DTOs;
using Contacts.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (CurrentPass.PasswordChar == '●')
            {
                Hide.BringToFront();
                CurrentPass.PasswordChar = '\0';
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (CurrentPass.PasswordChar == '\0')
            {
                Show.BringToFront();
                CurrentPass.PasswordChar = '●';
            }
        }

        private void Hide2_Click(object sender, EventArgs e)
        {
            if (NewPass.PasswordChar == '\0')
            {
                Show2.BringToFront();
                NewPass.PasswordChar = '●';
            }
        }

        private void Show2_Click(object sender, EventArgs e)
        {
            if (NewPass.PasswordChar == '●')
            {
                Hide2.BringToFront();
                NewPass.PasswordChar = '\0';
            }
        }

        private void Show3_Click(object sender, EventArgs e)
        {
            if (NewPass2.PasswordChar == '●')
            {
                Hide3.BringToFront();
                NewPass2.PasswordChar = '\0';
            }
        }

        private void Hide3_Click(object sender, EventArgs e)
        {
            if (NewPass2.PasswordChar == '\0')
            {
                Show3.BringToFront();
                NewPass2.PasswordChar = '●';
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(CurrentPass.Text) || string.IsNullOrEmpty(NewPass.Text) || string.IsNullOrEmpty(NewPass2.Text))
            {
                MessageBox.Show("لطفا اطلاعات را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (string.IsNullOrEmpty(CurrentPass.Text))
                    errorProvider1.SetError(CurrentPass, "*");

                if (string.IsNullOrEmpty(NewPass.Text))
                    errorProvider1.SetError(NewPass, "*");

                if (string.IsNullOrEmpty(NewPass2.Text))
                    errorProvider1.SetError(NewPass2, "*");
            }
            else
            {
                if (MD5Hash.MD5Hashing(CurrentPass.Text) != CurrentUser.Password)
                {
                    MessageBox.Show("رمز عبور صحیح نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(CurrentPass, "*");
                }
                else
                {
                    if (NewPass.Text != NewPass2.Text)
                    {
                        MessageBox.Show("رمز عبور جدید یکی نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(NewPass, "*");
                        errorProvider1.SetError(NewPass2, "*");
                    }
                    else
                    {
                        UserService us = new UserService();
                        us.ChangePass(CurrentUser.UserName, MD5Hash.MD5Hashing(NewPass.Text));
                        CurrentUser.Password = MD5Hash.MD5Hashing(NewPass.Text);
                        MessageBox.Show("رمز عبور با موفقیت تغییر یافت");
                    }
                }
            }
        }
    }
}
