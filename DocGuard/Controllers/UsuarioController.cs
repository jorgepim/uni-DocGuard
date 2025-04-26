using Microsoft.AspNetCore.Mvc;

namespace DocGuard.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
