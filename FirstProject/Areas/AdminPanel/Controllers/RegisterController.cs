using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize]
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
