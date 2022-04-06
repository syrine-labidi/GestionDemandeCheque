using Microsoft.AspNetCore.Mvc;

namespace GchequeWebApp.Controllers
{
    public class ChequeController : Controller
    {
        public IActionResult DetailCheque()
        {
            return View();
        }
    }
}
