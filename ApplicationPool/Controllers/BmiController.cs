using ApplicationPool.Models;
using ApplicationPool.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationPool.Controllers
{
    [Route("[controller]")]
    public class BmiController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate([FromBody]BmiModel model)
        {
            try
            {
                var response = CalculateBmi(model);

                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest("adasda");
            }
            
        }
        
        private Bmi CalculateBmi(BmiModel bmiModel)
        {
            var LastHeight = bmiModel.Height / 100;
            var index = bmiModel.Weight / (LastHeight * LastHeight);

            string group = index switch
            {
                < 18.5 => "underweight",
                < 25 => "Normal",
                < 30 => "over weight",
                _ => "Obese"
            };

            return new Bmi
            {
                Group = group,
                Index = index
            };
        } 
    }

}
