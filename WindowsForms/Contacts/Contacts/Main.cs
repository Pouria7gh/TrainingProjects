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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PeopleService ps = new PeopleService();
            List<PeopleViewModel> list = ps.GetAll();

            DataTable dt = new DataTable();
            dt.Columns.Add("نام");
            dt.Columns.Add("نام خانوادگی");
            dt.Columns.Add("جنسیت");
            dt.Columns.Add("تاریخ تولد");
            dt.Columns.Add("شماره تلفن");
            dt.Columns.Add("ایمیل");

            foreach (var item in list)
            {
                dt.Rows.Add(item.Name, item.Family, item.Gender, item.BirthDate, item.PhoneNumber, item.Email);
            }

            dataGridView1.DataSource = dt;

            if (CurrentUser.Role == 2)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
            string welcome = string.Format("{0} {1} {2} {3}", DateConvertor.ToShamsi(DateTime.Now).ToString(), CurrentUser.Family, CurrentUser.Name, "خوش امدید");
            Welcome.Text = welcome;
        }

        private void AddPeople_Click(object sender, EventArgs e)
        {
            AddContacts addContacts = new AddContacts();
            addContacts.Show();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUser AddUser = new AddUser();
            AddUser.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            PeopleService ps = new PeopleService();
            List<PeopleViewModel> list = ps.GetAll();

            DataTable dt = new DataTable();
            dt.Columns.Add("نام");
            dt.Columns.Add("نام خانوادگی");
            dt.Columns.Add("جنسیت");
            dt.Columns.Add("تاریخ تولد");
            dt.Columns.Add("شماره تلفن");
            dt.Columns.Add("ایمیل");

            foreach (var item in list)
            {
                dt.Rows.Add(item.Name, item.Family, item.Gender, item.BirthDate, item.PhoneNumber, item.Email);
            }

            dataGridView1.DataSource = dt;
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Search.Text))
            {
                PeopleService ps = new PeopleService();
                List<PeopleViewModel> list = ps.GetAll();

                DataTable dt = new DataTable();
                dt.Columns.Add("نام");
                dt.Columns.Add("نام خانوادگی");
                dt.Columns.Add("جنسیت");
                dt.Columns.Add("تاریخ تولد");
                dt.Columns.Add("شماره تلفن");
                dt.Columns.Add("ایمیل");

                foreach (var item in list)
                {
                    dt.Rows.Add(item.Name, item.Family, item.Gender, item.BirthDate, item.PhoneNumber, item.Email);
                }

                dataGridView1.DataSource = dt;
            }
            else
            {
                PeopleService ps = new PeopleService();
                List<PeopleViewModel> list = ps.Search(Search.Text);

                DataTable dt = new DataTable();
                dt.Columns.Add("نام");
                dt.Columns.Add("نام خانوادگی");
                dt.Columns.Add("جنسیت");
                dt.Columns.Add("تاریخ تولد");
                dt.Columns.Add("شماره تلفن");
                dt.Columns.Add("ایمیل");

                foreach (var item in list)
                {
                    dt.Rows.Add(item.Name, item.Family, item.Gender, item.BirthDate, item.PhoneNumber, item.Email);
                }

                dataGridView1.DataSource = dt;
            }
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            ChangePass changepass = new ChangePass();
            changepass.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string phonenumber = dataGridView1.SelectedCells[4].Value.ToString();
            PeopleService ps = new PeopleService();
            ps.Delete(phonenumber);


            List<PeopleViewModel> list = ps.GetAll();

            DataTable dt = new DataTable();
            dt.Columns.Add("نام");
            dt.Columns.Add("نام خانوادگی");
            dt.Columns.Add("جنسیت");
            dt.Columns.Add("تاریخ تولد");
            dt.Columns.Add("شماره تلفن");
            dt.Columns.Add("ایمیل");

            foreach (var item in list)
            {
                dt.Rows.Add(item.Name, item.Family, item.Gender, item.BirthDate, item.PhoneNumber, item.Email);
            }

            dataGridView1.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditContact editContact = new EditContact();
            editContact.Show();

            editContact.name.Text = dataGridView1.SelectedCells[0].Value.ToString();
            editContact.Family.Text = dataGridView1.SelectedCells[1].Value.ToString();
            editContact.Gender.Text = dataGridView1.SelectedCells[2].Value.ToString();

            if (!string.IsNullOrEmpty(dataGridView1.SelectedCells[3].Value.ToString()))
            {
                string[] bdate = dataGridView1.SelectedCells[3].Value.ToString().Split("/");
                editContact.BDYear.Text = bdate[0];
                editContact.BDMonth.Text = bdate[1];
                editContact.BDDay.Text = bdate[2];
            }

            editContact.PhoneNumber.Text = dataGridView1.SelectedCells[4].Value.ToString();
            editContact.OldPhoneNumber.Text = dataGridView1.SelectedCells[4].Value.ToString();
            editContact.Email.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }
    }
}
