using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
	public class _PersonelPartial:ViewComponent
	{
		private readonly IPersonesService _personelService;
		public _PersonelPartial(IPersonesService personelService)
		{
			_personelService = personelService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _personelService.GetAll();
			return View(values);
		}
	}
}
