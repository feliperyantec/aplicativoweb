using System;
using Microsoft.AspNetCore.Mvc;

namespace AplicativoWeb.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}