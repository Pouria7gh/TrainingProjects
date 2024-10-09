using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.DataLayer.Entities
{
    public class User
    {
        [Key]
        public string UserName { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public int Role { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public string BirthDate { get; set; }
    }
}
