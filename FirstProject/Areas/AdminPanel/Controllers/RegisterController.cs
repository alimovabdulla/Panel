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
		private readonly UserManager<FirstProject.Entities.AppUser> _userManager;
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
		public async Task<IActionResult> Register(string username, string password)
		{

			AppUser appUser = new AppUser();
			appUser.UserName = username;
			var result = await _userManager.CreateAsync(appUser, password);
		 

			await _userManager.AddPasswordAsync(appUser, password);

			_classContext.SaveChanges();
			return View();
		}

	}
}
