using Data.Contexts.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactsDbContext _contactsDbContext;

        public HomeController(IContactsDbContext contactsDbContext)
        {
            _contactsDbContext = contactsDbContext;
        }

        public IActionResult Index()
        {
            var contacts = _contactsDbContext.Contacts;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}