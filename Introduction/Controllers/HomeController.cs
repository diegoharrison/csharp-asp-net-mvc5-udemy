using Introduction.Models;
using System.Web.Mvc;

namespace Introduction.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var person = new Person()
            {
                PersonId = 1,
                Name = "Harrison",
                Type = "TI"
            };

            ViewData["PessoaId"] = person.PersonId;
            ViewData["Name"] = person.Name;
            ViewData["Type"] = person.Type;

            ViewBag.personId = person.PersonId;
            ViewBag.name = person.Name;
            ViewBag.type = person.Type;

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}