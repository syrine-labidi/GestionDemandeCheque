using Microsoft.AspNetCore.Mvc;

namespace GchequeWebApp.Controllers
{
    public class PersonneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
