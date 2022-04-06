using Microsoft.AspNetCore.Mvc;

namespace GchequeWebApp.Controllers
{
    public class InstitutionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
