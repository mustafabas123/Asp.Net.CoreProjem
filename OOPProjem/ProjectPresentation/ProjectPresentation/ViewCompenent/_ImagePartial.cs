using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.ViewCompenent
{
	public class _ImagePartial:ViewComponent
	{
		private readonly IImageService _imageService;
		public _ImagePartial(IImageService imageService)
		{
			_imageService = imageService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _imageService.GetAll();
			return View(values);
		}
	}
}
