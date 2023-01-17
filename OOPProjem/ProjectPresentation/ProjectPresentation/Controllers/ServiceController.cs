using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Project;
using ProjectPresentation.Models;

namespace ProjectPresentation.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values=_serviceService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service p) 
        {
            ServiceValidator serviceValidator= new ServiceValidator();
            ValidationResult result= serviceValidator.Validate(p);
            if (result.IsValid)
            {
                _serviceService.Insert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();    

        }
        public IActionResult DeleteService(int id)
        {
            var value=_serviceService.GetById(id);
            _serviceService.Delete(value);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateService(int id) 
        {
            var value = _serviceService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.Update(service);
            return RedirectToAction("Index");
        }
    }
}
