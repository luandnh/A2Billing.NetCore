using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NesopsRTC2.Models;

namespace NesopsRTC2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }         
        public IActionResult Contact()
        {
            return View();
        }        
        public IActionResult CallReport()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }     
        public IActionResult Support()
        {
            return View();
        }        
        public IActionResult TicketDetail()
        {
            return View();
        }
        public IActionResult Refill()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult Voucher()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
