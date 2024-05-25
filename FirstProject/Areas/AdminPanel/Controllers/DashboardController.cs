using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        

    }
}
