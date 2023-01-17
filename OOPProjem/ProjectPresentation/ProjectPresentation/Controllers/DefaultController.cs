using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IContactService _contactService;
        public DefaultController(IContactService contactService)
        {
            _contactService= contactService;
        }
		[AllowAnonymous]
		public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult MessageSend()
        {
            return PartialView();//Bir tane partial view döndürücek get olduğunda
        }
        [HttpPost]
        public IActionResult MessageSend(Contact c)
        {
            c.Date= DateTime.Parse(DateTime.Now.ToShortDateString());//Mesajın gönderilme tarihinde al ve contact paremetresine ata yani o anın tarihin al kodu
            _contactService.Insert(c);
            return RedirectToAction("Index");
        }
    }
}
