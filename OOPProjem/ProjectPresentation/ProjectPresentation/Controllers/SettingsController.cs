using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectPresentation.Models;

namespace ProjectPresentation.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController (UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task <IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel()
            {
                Name = values.Name,
                Surname = values.Surname,
                Email = values.Email,
                UserName = values.UserName,
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserUpdateViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if(model.Password ==model.RePassword)
            {
                values.Name= model.Name;
                values.Surname=model.Surname;
                values.Email=model.Email;
                values.UserName=model.UserName;
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.Password);
                var result =await _userManager.UpdateAsync(values);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index","Login");
                }
            }
            return View(); 
        }
    }
}
