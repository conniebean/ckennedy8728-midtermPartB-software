using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ckennedy8728_midtermPartB_software.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult DogOptions()
        {
            return View();
        }

        public IActionResult LargeDog()
        {
            return View();
        }

        public IActionResult SmallDog()
        {
            return View();
        }
    }
}
