using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NesopsRTC2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Successful()
        {
            return RedirectToAction("Index", "Home");
        }        
        public IActionResult AdminSuccessful()
        {
            return RedirectToAction("Index", "Admin");
        }
    }
}