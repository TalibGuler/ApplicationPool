using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationPool.Controllers
{
    public class RandomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
