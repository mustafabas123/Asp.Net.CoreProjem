using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
	public class _AddresPartial:ViewComponent
	{
		private readonly IAddressService _addressService;
		public _AddresPartial(IAddressService addressService)
		{
			_addressService = addressService;
		}
		public IViewComponentResult Invoke()
		{
			var values=_addressService.GetAll();
			return View(values);
		}
	}
}
