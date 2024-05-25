using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Areas.AdminPanel.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
