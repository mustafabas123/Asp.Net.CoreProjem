using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
    public class _CashDeposistsDashBoardPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
