using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace ProjectPresentation.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        public ImageController (IImageService imageService)
        {
            _imageService = imageService;
        }
        public IActionResult Index()
        {
            var values = _imageService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Image p)
        {
            ImageValidation imageValidation= new ImageValidation();
            ValidationResult result=imageValidation.Validate(p);
            if (result.IsValid)
            {
                _imageService.Insert(p);
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
        public IActionResult DeleteImage(int id)
        {
            var value=_imageService.GetById(id);
            _imageService.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateImage(int id)
        {
            var value = _imageService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateImage(Image p)
        {
            _imageService.Update(p);
            return RedirectToAction("Index");
        }
    }
}
