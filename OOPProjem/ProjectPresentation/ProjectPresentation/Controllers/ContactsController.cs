using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactService _contactService;
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            var values=_contactService.GetAll();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var value=_contactService.GetById(id);
            _contactService.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DetailContact(int id)
        {
            var value= _contactService.GetById(id);
            return View(value);
        }
    }
}
