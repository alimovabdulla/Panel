using FirstProject.DataBase;
using FirstProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using FirstProject.Entities;
namespace FirstProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]

    public class RegisterController : Controller
    {
        private readonly UserManager< FirstProject.Entities.AppUser> _userManager;
        private readonly SignInManager<FirstProject.Entities.AppUser> _signInManager;
        private readonly ClassContext _classContext;
        public RegisterController(UserManager<FirstProject.Entities.AppUser> userManager, ClassContext classContext, SignInManager<FirstProject.Entities.AppUser> signInManager)
        {
            _userManager = userManager;
            _classContext = classContext;
            _signInManager = signInManager;

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(FirstProject.Entities.AppUser appUser)
        {

            _userManager.AddPasswordAsync(appUser, appUser.Password);
            var result = await _userManager.CreateAsync(appUser);
            _classContext.SaveChanges();
            return View();
        }

    }
}
