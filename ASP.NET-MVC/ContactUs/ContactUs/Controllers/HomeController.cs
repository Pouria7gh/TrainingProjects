using ContactUs.Data;
using ContactUs.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactUs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Messages()
        {
            return View(Data.MyDbContext.Messages);
        }
        [HttpPost]
        public IActionResult SendMessage(ContactUs.Models.Message message)
        {
            MyDbContext.Messages.Add(message);
            return Redirect("/Home/Messages");
        }
    }
}
