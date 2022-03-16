using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ckennedy8728_midtermPartB_software.Controllers
{
    public class ReptilesController : Controller
    {
        public IActionResult ReptileOptions()
        {
            return View();
        }

        public IActionResult HasLegs()
        {
            return View();
        }

        public IActionResult HasNoLegs()
        {
            return View();
        }
    }
}
