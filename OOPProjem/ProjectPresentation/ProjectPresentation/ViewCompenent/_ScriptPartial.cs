using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
	public class _ScriptPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
