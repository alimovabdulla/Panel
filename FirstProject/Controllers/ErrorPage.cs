using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class ErrorPage : Controller
    {
        public IActionResult Error1()
        {
            return View();
        }
    }
}
