using FirstProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace FirstContext1.Areas.AdminPanel.Controllers
{

    [Area("AdminPanel")]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
             
            return View();
             
        }
        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
            AppUser user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {

                ModelState.TryAddModelError("", "Bele Bir Istifadeci Yoxdur");
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(user, password, true, false);
            if (result.Succeeded)
            {


                return RedirectToAction("index", "Dashboard");


            }
            else { ModelState.AddModelError("", "Sifre Yalnisdir"); }

            return View();
        }
    }
}
