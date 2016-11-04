using KnockoutjsCRUDinMVC.Models;
using System.Web.Mvc;

namespace KnockoutjsCRUDinMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Basic()
        {
            return View();
        }

        public ActionResult Advanced()
        {
            var person = new Person
            {
                FirstName = "thuy",
                LastName = "bui"
            };
            return View(person);
        }
    }
}