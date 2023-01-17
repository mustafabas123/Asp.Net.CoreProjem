using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
    public class _OverViewDashBoardPartial:ViewComponent
    {
        ProjeContext c=new ProjeContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.AdminsCount = c.Admins.Count();
            ViewBag.MessageCount=c.Contacts.Count();
            ViewBag.NewsCount=c.News.Count();
            ViewBag.PersonelsCount=c.Personels.Count();

            ViewBag.Personel1 = c.Personels.Where(x => x.PersonelName == "Mustafa Baş").Select(y => y.Title).FirstOrDefault();
            ViewBag.Personel2=c.Personels.Where(x =>x.PersonelName == "Ayşenur Doğanay").Select(y =>y.Title).FirstOrDefault();
            ViewBag.Personel3=c.Personels.Where(x=>x.PersonelName == "Gizem Çınar").Select(y =>y.Title).FirstOrDefault();
            ViewBag.Personel4=c.Personels.Where(x =>x.PersonelName == "Akif Gönen").Select(y=>y.Title).FirstOrDefault();
             
            ViewBag.Service1 = c.Services.Where(x => x.Title ==  "Organik Süt ürünleri").Select(y => y.Description).FirstOrDefault();
            ViewBag.Service2=c.Services.Where(x =>x.Title == "Tahıl").Select(y => y.Description).FirstOrDefault();
            ViewBag.Service3=c.Services.Where(x =>x.Title == "Et Ürünleri").Select(y => y.Description).FirstOrDefault();
            ViewBag.Service4=c.Services.Where(x => x.Title == "Sebze Ürünleri").Select(y => y.Description).FirstOrDefault();

            return View();
        }
    }
}
