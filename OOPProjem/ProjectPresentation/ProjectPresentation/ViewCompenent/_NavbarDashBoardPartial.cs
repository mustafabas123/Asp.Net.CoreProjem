using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
    public class _NavbarDashBoardPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
