using FirstProject.DataBase;
using FirstProject.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using FirstProject.Entities;
using FirstProject.DTOs.RegisterDTOs;
namespace FirstProject.Areas.AdminPanel.Controllers
{
    [Authorize]

    [Area("AdminPanel")]

    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ClassContext _classContext;
        public RegisterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ClassContext classContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _classContext = classContext;

        }
        [HttpGet]
        public ActionResult Register() { return View(); }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            AppUser appUser = new AppUser();
            appUser.UserName = registerDTO.Email;
            appUser.PhoneNumber = registerDTO.PhoneNumber;
            await _classContext.SaveChangesAsync();
            var result = await _userManager.CreateAsync(appUser, registerDTO.Password);
            if (!result.Succeeded)
            {
                string error = "";
                foreach (var item in result.Errors)
                {
                    error += item;
                }
                ModelState.AddModelError(string.Empty, error);

            }
            await _classContext.SaveChangesAsync();

            return View();
        }
    }
}
