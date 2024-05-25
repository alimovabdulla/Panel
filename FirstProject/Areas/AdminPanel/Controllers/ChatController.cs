using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Areas.AdminPanel.Controllers
{
    [Area("Chat")]
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
