using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var values=_addressService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAddress()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAddress(Address a)
        {
            AddressValidation addressValidation=new AddressValidation();
            ValidationResult result =addressValidation.Validate(a);
            if(result.IsValid)
            {
                _addressService.Update(a);
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

        [HttpGet]
        public IActionResult UpdateAddress(int id)
        {
            var value = _addressService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAddress(Address a)
        {
            AddressValidation addressValidation=new AddressValidation();
            ValidationResult result=addressValidation.Validate(a);
            if(result.IsValid )
            {
                _addressService.Update(a);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.ErrorCode,item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
