using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonesService _personelService;
        public PersonelController (IPersonesService personelService)
        {
            _personelService = personelService;
        }
        public IActionResult Index()
        {
            var values=_personelService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPersonel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPersonel(Personels p)
        {
            PersonelValidator personelValidator = new PersonelValidator();
            ValidationResult result = personelValidator.Validate(p);

            if (result.IsValid)//validation sınıfında belirtiğim koşulları takılmadıysa eklem işlemin gerçekleştir
            {
              _personelService.Insert(p);
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
        public IActionResult DeletePersonel(int id)
        {
            var value = _personelService.GetById(id);
            _personelService.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePersonel(int id)
        {
            var value = _personelService.GetById(id);
            return View(value);
        }
        public IActionResult UpdatePersonel(Personels p)
        {
            _personelService.Update(p);
            return RedirectToAction("Index");
        }

    }
}
