using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoysNGirls.Areas.Teachers.Controllers
{
    [Area("Teachers")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "There is one teacher in the class";
            return View();
        }
    }
}
