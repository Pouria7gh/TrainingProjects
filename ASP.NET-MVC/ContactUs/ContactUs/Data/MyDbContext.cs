using ContactUs.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactUs.Data
{
    public static class MyDbContext
    {
        public static List<ContactUs.Models.Message> Messages = new List<ContactUs.Models.Message>();
    }
}
