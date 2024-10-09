using Contacts.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.DataLayer.DTOs
{
    public class PeopleViewModel 
    {
        [Key]
        public string Name {  get; set; }

        public string Family {  get; set; }

        public string Gender { get; set; }

        public string BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
