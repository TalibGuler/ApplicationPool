using ApplicationPool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationPool.Controllers
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
            List<AppModel> test = new List<AppModel>();
            test.Add(new AppModel
            {
                Id = 1,
                Name = "Todo App",
                Image = "/image/todo.jpg",
                Path = "Todo"
            });

            test.Add(new AppModel
            {
                Id = 2,
                Name = "BMI Calculator",
                Image = "/image/bmi.jpg",
                Path = "Bmi"
            });

            test.Add(new AppModel
            {
                Id = 3,
                Name = "Random Quates",
                Image = "/image/random.jpg",
                Path = "Random"
            });

            test.Add(new AppModel
            {
                Id = 4,
                Name = "Weather App",
                Image = "/image/weather.jpg",
                Path = "Weather"
            });

            return View(test);
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
