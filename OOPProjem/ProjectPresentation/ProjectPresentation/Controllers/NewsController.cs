using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;
        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }
        public IActionResult Index()
        {
            var values = _newsService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddNews()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNews(News p)
        {
            NewsValidation newValidation=new NewsValidation();
            ValidationResult result=newValidation.Validate(p);
            if (result.IsValid)
            {
                p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());//Haber post olduğu zaman yani eklendiğinde haberin eklenme zamanını burda otomatik ata
                p.Status = false; //Haber eklendiği anda durumunu false yap default olarak
                _newsService.Insert(p);
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
        public IActionResult UpdateNews(int id)
        {
            var value=_newsService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateNews(News p)
        {
            _newsService.Update(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteNews(int id)
        {
            var value = _newsService.GetById(id);
            _newsService.Delete(value);
            return RedirectToAction("Index");
        }
        public IActionResult StatusChangeToTrue(int id)
        {
            _newsService.NewsStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult StatusChangeToFalse(int id)
        {
            _newsService.NewsStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
