using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace FirstContext1.Areas.AdminPanel.Controllers
{
    
    [Area("AdminPanel")]
    public class LoginController : Controller
    {
         
        public IActionResult Index()
        {
            return View();
        }
    }
}
