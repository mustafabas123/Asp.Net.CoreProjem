using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.Controllers
{
	public class AdminController : Controller
	{
		private readonly IAdminsService _adminService;
		public AdminController(IAdminsService adminService)
		{
			_adminService = adminService;
		}
		public IActionResult Index()
		{
			var values=_adminService.GetAll();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddAdmin()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddAdmin(Admins a)
		{
			AdminValidation adminValidation= new AdminValidation();
			ValidationResult result= adminValidation.Validate(a);
			if (result.IsValid)
			{
				_adminService.Insert(a);
				return RedirectToAction("Index");
			}
			else
			{
				foreach(var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();

		}
		public IActionResult DeleteAdmin(int id)
		{
			var value=_adminService.GetById(id);
			_adminService.Delete(value);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateAdmin(int id)
		{
			var value= _adminService.GetById(id);
			return View(value);

		}
		[HttpPost]
		public IActionResult UpdateAdmin(Admins a)
		{
			AdminValidation adminValidation= new AdminValidation();
			ValidationResult result=adminValidation.Validate(a);
			if(result.IsValid)
			{
                _adminService.Update(a);
                return RedirectToAction("Index");
            }
			else
			{
				foreach(var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorCode);
				}
			}
			return View();

		}
	}
}
