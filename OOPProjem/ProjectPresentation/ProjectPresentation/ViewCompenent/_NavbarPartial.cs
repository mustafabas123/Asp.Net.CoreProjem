using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
	public class _NavbarPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
