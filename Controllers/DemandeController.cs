using Microsoft.AspNetCore.Mvc;

namespace GchequeWebApp.Controllers
{
    public class DemandeController : Controller
    {
        public IActionResult CreateDemande()
        {
            return View();
        }
        public IActionResult RechercherDemande()
        {
            return View();
        }
        public IActionResult ConsulterDemande()
        {
            return View();
        }
    }
}
