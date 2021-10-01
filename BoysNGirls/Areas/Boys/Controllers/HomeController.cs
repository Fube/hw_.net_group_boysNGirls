using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoysNGirls.Areas.Boys.Controllers
{
    [Area("Boys")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "There are 16 boys in the class";
            return View();
        }
    }
}
