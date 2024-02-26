using Microsoft.AspNetCore.Mvc;

namespace Gestionale_Edile.Controllers
{
    public class PagamentoController : Controller
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
