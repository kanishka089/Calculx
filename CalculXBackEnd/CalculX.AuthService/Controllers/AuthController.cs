using Microsoft.AspNetCore.Mvc;

namespace CalculX.AuthService.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
