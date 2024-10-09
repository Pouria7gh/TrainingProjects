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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (name.Text == string.Empty || Family.Text == string.Empty || UserName.Text == string.Empty ||
                Password.Text == string.Empty || rPassWord.Text == string.Empty || PhoneNumber.Text == string.Empty ||
                Gender.Text == string.Empty || BDDay.Text == string.Empty || BDMonth.Text == string.Empty ||
                BDYear.Text == string.Empty)
            {
                if (name.Text == string.Empty)
                    errorProvider1.SetError(name, "*");
                if (Family.Text == string.Empty)
                    errorProvider1.SetError(Family, "*");
                if (Password.Text == string.Empty)
                    errorProvider1.SetError(Password, "*");
                if (rPassWord.Text == string.Empty)
                    errorProvider1.SetError(rPassWord, "*");
                if (PhoneNumber.Text == string.Empty)
                    errorProvider1.SetError(PhoneNumber, "*");
                if (Gender.Text == string.Empty)
                    errorProvider1.SetError(Gender, "*");
                if (BDDay.Text == string.Empty)
                    errorProvider1.SetError(BDDay, "*");
                if (BDMonth.Text == string.Empty)
                    errorProvider1.SetError(BDMonth, "*");
                if (BDYear.Text == string.Empty)
                    errorProvider1.SetError(BDYear, "*");
                if (UserName.Text == string.Empty)
                    errorProvider1.SetError(UserName, "*");

                MessageBox.Show("لطفا اطلاعات را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Password.Text != rPassWord.Text)
            {
                MessageBox.Show("رمز عبور یکی نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(Password, "*");
                errorProvider1.SetError(rPassWord, "*");
            }
            else if (int.Parse(BDDay.Text) > 30 || int.Parse(BDMonth.Text) > 12)
            {
                MessageBox.Show("تاریخ تولد صحیح نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (int.Parse(BDDay.Text) > 30)
                    errorProvider1.SetError(BDDay, "*");
                if (int.Parse(BDMonth.Text) > 12)
                    errorProvider1.SetError(BDMonth, "*");
            }
            else
            {
                UserService us = new UserService();
                UserViewModel vm = new UserViewModel()
                {
                    Password = rPassWord.Text,
                    Family = Family.Text,
                    BirthDate = BDYear.Text + " " + BDMonth.Text + " " + BDDay.Text,
                    PhoneNumber = PhoneNumber.Text,
                    UserName = UserName.Text,
                    Name = name.Text,
                    Gender = Gender.Text,
                };
                

                if (RoleCB.Checked)
                {
                    vm.Role = 2;
                }
                else
                {
                    vm.Role = 1;
                }

                bool ok = us.Insert(vm);


                if (ok)
                    MessageBox.Show("کاربر اضافه شد");
                else
                    MessageBox.Show("کاربر اضافه نشد");
            }
        }

        private void BDDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BDMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BDYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Hide2_Click(object sender, EventArgs e)
        {
            if (rPassWord.PasswordChar == '\0')
            {
                Show2.BringToFront();
                rPassWord.PasswordChar = '●';
            }
        }

        private void Show2_Click_1(object sender, EventArgs e)
        {
            if (rPassWord.PasswordChar == '●')
            {
                Hide2.BringToFront();
                rPassWord.PasswordChar = '\0';
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


        private void Show_Click_1(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '●')
            {
                Hide.BringToFront();
                Password.PasswordChar = '\0';
            }
        }


        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            UserService us = new UserService();
            if (!us.CheckUserName(UserName.Text))
            {
                errorProvider1.SetError(UserName, "نام کاربری تکراری است");

            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == 2)
                RoleCB.Enabled = true;
            else
                RoleCB.Enabled = false;
        }

        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
