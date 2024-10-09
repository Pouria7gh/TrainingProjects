using Contacts.DataLayer.Convertors;
using Contacts.DataLayer.DTOs;
using Contacts.DataLayer.Entities;
using Contacts.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.DataLayer.Services
{
    public class UserService
    {
        public bool Insert(UserViewModel Entity)
        {
            User newUser = new User()
            {
                Family = Entity.Family,
                Name = Entity.Name,
                UserName = Entity.UserName,
                PhoneNumber = Entity.PhoneNumber,
                BirthDate = Convert.ToDateTime(Entity.BirthDate).ToMiladi().ToString(),
                Password = MD5Hash.MD5Hashing(Entity.Password),
                Gender = Entity.Gender,
                Role = Entity.Role
            };
            try
            {
                MyDbContext db = new MyDbContext();
                db.Users.Add(newUser);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public UserViewModel Login(string username, string password)
        {
            MyDbContext db = new MyDbContext();
            var user = db.Users.Where(x => x.UserName.ToLower() == username.ToLower() && x.Password == password);
            UserViewModel vm = new UserViewModel();
            foreach (var item in user)
            {
                vm.Role = item.Role;
                vm.Password = item.Password;
                vm.Name = item.Name;
                vm.UserName = item.UserName;
                vm.Family = item.Family;
            }
            return vm;
        }

        public bool CheckUserName(string username)
        {
            MyDbContext db = new MyDbContext();
            var list = db.Users.Where(x => x.UserName.ToLower() == username.ToLower());
            bool check = true;
            foreach (var item in list)
            {
                if (!string.IsNullOrEmpty(item.UserName))
                {
                    check = false;
                }
            }
            return check;
        }

        public void ChangePass(string username,string password)
        {
            MyDbContext db = new MyDbContext();
            var user = db.Users.Where(x => x.UserName.ToLower() == username.ToLower());
            foreach (var item in user)
            {
                item.Password = password;
            }
            db.SaveChanges();
        }
    }
}
