using Microsoft.AspNetCore.Mvc;

namespace MvcView.Controllers
{
	public class DigerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Sayfa2()
		{
			return View("Tablo");
		}
	}
}