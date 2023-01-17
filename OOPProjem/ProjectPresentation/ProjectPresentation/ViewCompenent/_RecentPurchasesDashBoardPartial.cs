using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
    public class _RecentPurchasesDashBoardPartial:ViewComponent
    {
        private readonly IContactService _contactService;
        public _RecentPurchasesDashBoardPartial(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetAll();
            return View(values);
        }
    }
}
