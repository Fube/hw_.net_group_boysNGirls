using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoysNGirls.Areas.Girls.Controllers
{
    [Area("Girls")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "There are 2 girls in the class";
            return View();
        }
    }
}
