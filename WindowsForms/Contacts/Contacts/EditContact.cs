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
    public partial class EditContact : Form
    {
        public EditContact()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string phonenum = OldPhoneNumber.Text;
            PeopleViewModel pv = new PeopleViewModel()
            {
                Name = name.Text,
                Family = Family.Text,
                Gender = Gender.Text,
                PhoneNumber = PhoneNumber.Text,
                Email = Email.Text
            };

            if (!string.IsNullOrEmpty(BDYear.Text) && !string.IsNullOrEmpty(BDMonth.Text) && !string.IsNullOrEmpty(BDDay.Text))
                pv.BirthDate = DateConvertor.ToMiladi(Convert.ToDateTime($"{BDYear.Text}/{BDMonth.Text}/{BDDay.Text}")).ToString();

            PeopleService ps = new PeopleService();
            bool check = ps.EditContact(pv , phonenum);
            if (check)
            {
                MessageBox.Show("ویرایش کاربر با موفقیت انجام شد");
            }
            else
            {
                MessageBox.Show("خطای ناشناخته");
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
