using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ckennedy8728_midtermPartB_software.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult CatOptions()
        {
            return View();
        }

        public IActionResult CatWithHair()
        {
            return View();
        }

        public IActionResult CatWithNoHair()
        {
            return View();
        }
    }
}
