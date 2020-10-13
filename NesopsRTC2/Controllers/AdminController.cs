using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NesopsRTC2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cards()
        {
            return View();
        }        
        public IActionResult CardNew()
        {
            return View();
        }
        public IActionResult VoIPSettings()
        {
            return View();
        }
        public IActionResult CardGroups()
        {
            return View();
        }        
        public IActionResult Prefixes()
        {
            return View();
        }       
        public IActionResult CallLogs()
        {
            return View();
        }        
        public IActionResult CardDetail()
        {
            return View();
        }       
        public IActionResult RefillLogs()
        {
            return View();
        }       
        public IActionResult Vouchers()
        {
            return View();
        }       
        public IActionResult CallPlans()
        {
            return View();
        }        
        public IActionResult Ratecards()
        {
            return View();
        }       
        public IActionResult Rates()
        {
            return View();
        }        
        public IActionResult TicketComponents()
        {
            return View();
        }        
        public IActionResult CustomerTickets()
        {
            return View();
        }       
        public IActionResult TicketDetail()
        {
            return View();
        }
    }
}