using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectPresentation.Models;

namespace ProjectPresentation.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;
		public LoginController (UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
		{
			_userManager=userManager;
			_signInManager = signInManager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			
			return View();
		}
		[HttpPost]
		public async Task <IActionResult> Index(LoginViewModel model)
		{
			if (ModelState.IsValid) //LoginViewModel içindeki required işlemleri sağlandıysa
            {
				var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
				if (result.Succeeded) //Başarılı giriş yapıldıysa
				{
					return RedirectToAction("Index", "News");
				}
				else
				{
					return RedirectToAction("Index");
				}
			}
			return View();
		}
		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SignUp(RegisterViewModel model)
		{
			AppUser appUser = new AppUser()
			{
				Name = model.Name,
				Surname = model.Surname,
				UserName = model.UserName,
				Email = model.Mail
			};
			if (model.Pasword == model.RePassword)
			{
				var result = await _userManager.CreateAsync(appUser, model.Pasword);
				if(result.Succeeded)
				{
					return RedirectToAction("Index", "Login");
				}
				else
				{
					foreach(var item in result.Errors)
					{
						ModelState.AddModelError(" ", item.Description);
					}
				}
			}
			return View(model);
		}
		
	}
}
