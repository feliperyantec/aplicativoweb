using Microsoft.AspNetCore.Mvc;

namespace AplicativoWeb.Controllers
{ 
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


    }
}