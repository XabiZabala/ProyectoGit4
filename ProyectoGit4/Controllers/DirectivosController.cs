using Microsoft.AspNetCore.Mvc;

namespace ProyectoGit4.Controllers
{
    public class DirectivosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ver()
        {
            return View();
        }
    }
}
