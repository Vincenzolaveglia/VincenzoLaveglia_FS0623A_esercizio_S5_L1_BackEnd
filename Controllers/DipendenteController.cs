using Microsoft.AspNetCore.Mvc;

namespace Gestionale_Edile.Controllers
{
    public class DipendenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
