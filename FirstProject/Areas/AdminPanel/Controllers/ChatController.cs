using Microsoft.AspNetCore.Mvc;

namespace FirstContext1.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        
        
        }

        public IActionResult Index(int a)
        {
            return View();
        }


    }
}
