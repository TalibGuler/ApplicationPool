using ApplicationPool.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApplicationPool.Controllers
{
    public class RandomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("api/randomQuate")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            using var client = new HttpClient(); // İstek atma
            var response = await client.GetStringAsync("https://api.quotable.io/random");

            var model = JsonSerializer.Deserialize<RandomModel>(response);
            return Ok(model);
        }


    }
}
