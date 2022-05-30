using Microsoft.AspNetCore.Mvc;

namespace MvcView.Controllers
{
    public class HomeController : Controller
    {

        //IActionResult

        // ViewResult => Action metodun geriye view dönmesi için kullanılan result type'tır.. IActionResult interface'inden türemiştir...

        public ViewResult Index()
        {
            return View();
        }


    }
}
