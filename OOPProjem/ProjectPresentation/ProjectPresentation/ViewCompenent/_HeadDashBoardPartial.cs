using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
    public class _HeadDashBoardPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
