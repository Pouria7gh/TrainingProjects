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
    public partial class AddContacts : Form
    {
        public AddContacts()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (name.Text == string.Empty || PhoneNumber.Text == string.Empty || Gender.Text == string.Empty)
            {
                MessageBox.Show("لطفا اطلاعات را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (name.Text == string.Empty)
                    errorProvider1.SetError(name, "*");

                if (PhoneNumber.Text == string.Empty)
                    errorProvider1.SetError(PhoneNumber, "*");

                if (Gender.Text == string.Empty)
                    errorProvider1.SetError(Gender, "*");
            }
            else
            {
                PeopleViewModel vm = new PeopleViewModel()
                {
                    Name = name.Text,
                    Email = Email.Text,
                    Family = Family.Text,
                    PhoneNumber = PhoneNumber.Text,
                    Gender = Gender.Text
                };


                if (BDYear.Text != string.Empty && BDMonth.Text != string.Empty && BDDay.Text != string.Empty)
                {
                    if (int.Parse(BDDay.Text) < 31 && int.Parse(BDMonth.Text) < 13)
                    {
                        string v = BDYear.Text + " " + BDMonth.Text + " " + BDDay.Text;
                        vm.BirthDate = Convert.ToDateTime(v).ToString();
                    }
                    else
                    {
                        MessageBox.Show("تاریخ تولد صحیح نمی باشد");
                        return;
                    }
                }
                else
                    vm.BirthDate = string.Empty;


                PeopleService ps = new PeopleService();
                bool add = ps.Insert(vm);

                if (add)
                    MessageBox.Show("مخاطب ذخیره شد");
                else
                    MessageBox.Show("مخاطب ذخیره نشد");
            }
        }

        private void BDYear_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BDDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            PeopleService ps = new PeopleService();
            if (!ps.CheckPhoneNumber(PhoneNumber.Text))
            {
                errorProvider2.SetError(PhoneNumber, "کاربری با این شماره تلفن وجود دارد");
            }
        }
    }
}
