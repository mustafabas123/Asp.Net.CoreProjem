using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
    public class _ScriptDashBoardPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
