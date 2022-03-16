using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ckennedy8728_midtermPartB_software.Models;
using ckennedy8728_midtermPartB_software.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ckennedy8728_midtermPartB_software.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            string userName = UserHelper.GetPlayerName(HttpContext);
            userName = user.UserName;
            if (userName == null || userName.Length < 4 || userName.Length > 10) //player name is empty, return the view
            {
                return View(user);
            }
            else
            {
                UserHelper.SavePlayerName(HttpContext, userName);
                return RedirectToAction("PickAnAnimal");
            }
            
        }

        [HttpGet]
        public IActionResult PickAnAnimal()
        {
            return View();
        }

        public IActionResult WorkInProgress()
        {
            return View();
        }


    }
}
