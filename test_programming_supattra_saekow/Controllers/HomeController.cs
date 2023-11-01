using System;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test_programming_supattra_saekow.Models;

namespace test_programming_supattra_saekow.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Q1()
        {
           return View();
        }

        public IActionResult Q2()
        {
            return View();
        }
        public IActionResult Q3()
        {
            return View();
        }
        public IActionResult Q4()
        {
            return View();
        }
        public IActionResult Q5()
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