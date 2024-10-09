using Contacts.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.DataLayer.Model
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("Data Source=.;Initial Catalog=MyCon4;Integrated Security=True")
        {
            
        }
         public DbSet<People> People { get; set; }
         public DbSet<User> Users { get; set; }
    }
}
