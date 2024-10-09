using Contacts.DataLayer.Convertors;
using Contacts.DataLayer.DTOs;
using Contacts.DataLayer.Entities;
using Contacts.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Contacts.DataLayer.Services
{
    public class PeopleService
    {
        public bool Insert(PeopleViewModel Entity)
        {
            MyDbContext db = new MyDbContext();
            People NewPeople = new People()
            {
                Name = Entity.Name,
                Family = Entity.Family,
                Email = Entity.Email,
                Gender = Entity.Gender,
                PhoneNumber = Entity.PhoneNumber,
            };
            if (Entity.BirthDate == string.Empty)
                NewPeople.BirthDate = Entity.BirthDate;
            else
                NewPeople.BirthDate = Convert.ToDateTime(Entity.BirthDate).ToMiladi().ToString();

            try
            {
                db.People.Add(NewPeople);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<PeopleViewModel> GetAll()
        {
            MyDbContext db = new MyDbContext();
            List<PeopleViewModel> vm = new List<PeopleViewModel>();

            var List = db.People.Select(c => new PeopleViewModel
            {
                Name= c.Name,
                Family= c.Family,
                Email= c.Email,
                Gender= c.Gender,
                PhoneNumber= c.PhoneNumber,
                BirthDate= c.BirthDate
            });

            foreach (var item in List)
            {
                if (!string.IsNullOrEmpty(item.BirthDate))
                    item.BirthDate = DateConvertor.ToShamsi(Convert.ToDateTime(item.BirthDate));
                vm.Add(item);
            }

            return vm.ToList();
        }

        public List<PeopleViewModel> Search(string parameter)
        {
            MyDbContext db = new MyDbContext();
            List<PeopleViewModel> vm = new List<PeopleViewModel>();

            var List = db.People.Where(x => x.Name.Contains(parameter) || x.Family.Contains(parameter) || x.PhoneNumber.Contains(parameter)).Select(c => new PeopleViewModel
            {
                Name = c.Name,
                Family = c.Family,
                Email = c.Email,
                Gender = c.Gender,
                PhoneNumber = c.PhoneNumber,
                BirthDate = c.BirthDate
            }
            );

            foreach (var item in List)
            {
                if (!string.IsNullOrEmpty(item.BirthDate))
                    item.BirthDate = DateConvertor.ToShamsi(Convert.ToDateTime(item.BirthDate));
                vm.Add(item);
            }

            return vm.ToList();
        }

        public void Delete(string phoneNum)
        {
            MyDbContext db = new MyDbContext();
            var person = db.People.Where(x => x.PhoneNumber.ToLower() == phoneNum.ToLower());

            foreach (var item in person)
            {
                db.People.Remove(item);
            }
            db.SaveChanges();
        }

        public bool CheckPhoneNumber (string phoneNum)
        {
            MyDbContext db = new MyDbContext();
            var list = db.People.Where(x => phoneNum == x.PhoneNumber).ToList();
            bool check = true;
            foreach (var item in list)
            {
                if (!string.IsNullOrEmpty(item.PhoneNumber))
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        public bool EditContact(PeopleViewModel vm , string phonenum)
        {
            MyDbContext db = new MyDbContext();
            var list = db.People.Where(x => x.PhoneNumber == phonenum);
            bool check = false;
            foreach(var item in list)
            {
                item.PhoneNumber = vm.PhoneNumber;
                item.BirthDate = vm.BirthDate;
                item.Email = vm.Email;
                item.Family = vm.Family;
                item.Name = vm.Name;
                item.Gender = vm.Gender;
                check = true;
            }
            db.SaveChanges();
            return check;
        }
    }
}
