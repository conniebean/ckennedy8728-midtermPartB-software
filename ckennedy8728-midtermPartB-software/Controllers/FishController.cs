using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ckennedy8728_midtermPartB_software.Controllers
{
    public class FishController : Controller
    {
        public IActionResult FishOptions()
        {
            return View();
        }

        public IActionResult BottomFeeder()
        {
            return View();
        }

        public IActionResult TopFeeder()
        {
            return View();
        }
    }
}
