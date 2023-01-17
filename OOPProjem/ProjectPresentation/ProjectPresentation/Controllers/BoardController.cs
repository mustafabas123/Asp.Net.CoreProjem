using Microsoft.AspNetCore.Mvc;

namespace ProjectPresentation.Controllers
{
    public class BoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
