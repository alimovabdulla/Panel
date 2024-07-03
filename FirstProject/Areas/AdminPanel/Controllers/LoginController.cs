using FirstProject.DataBase;
using FirstProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace FirstContext1.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ClassContext _classContext;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ClassContext classContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _classContext = classContext;

        }
         
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {

            AppUser appUser = await _userManager.FindByNameAsync(username);
            if (appUser == null)
            {
                ModelState.TryAddModelError("", "User Movcud deyil");
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(appUser, password, true, false);
            if (result.Succeeded)
            {


                return RedirectToAction("Index", "Home");
                 
            }
            else
            {
                ModelState.AddModelError("", "Sifre Yalnisdir...");
                return View();

            }



        }
    }
}