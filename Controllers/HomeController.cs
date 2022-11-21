using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Home()
        {
            return View();
        }
    }
}
