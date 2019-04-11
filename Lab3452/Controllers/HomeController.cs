using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab345.Models;
using Lab345.ViewModels;
using Lab345.Data;

namespace Lab345.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly Database _data;

        public HomeController(Database data)
        {
            _data = data;
            
        }
        public IActionResult Index()
        {
            ViewBag.cheeses = _data.Cheeses.ToList();
            return View();
        }

        public IActionResult Privacy()
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
