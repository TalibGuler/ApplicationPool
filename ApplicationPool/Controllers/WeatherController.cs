using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ApplicationPool.Models;

namespace ApplicationPool.Controllers
{
    public class WeatherController : Controller
    {
        private string[] Cities = new[]
        {
            "Istanbul", "London", "Berlin", "Paris"
        };
        
        public async Task<IActionResult> Index()
        {
            var weathers = new List<WeatherModel>(Cities.Length);

            foreach (var city in Cities)
            {
                weathers.Add(await GetWeatherFromCityName(city));
            }
            
            return View(weathers);
        }

        private async Task<WeatherModel> GetWeatherFromCityName(string cityName)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "weatherapi-com.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "4f8234a62amsh42185b0b78f249cp12e57ajsnb401d01fcbbf");

            var json = await client.GetStringAsync(CityUrl("Istanbul"));
            var model = JsonSerializer.Deserialize<Root>(json);

            var response = new WeatherModel()
            {
                Celcius = (int)model.Current.TempC,
                City = cityName,
                Country = model.Location.Country,
                Humidity = model.Current.Humidity,
                Wind = model.Current.WindMph,
                Weather = model.Current.Condition.Text
            };
            return response;
        }

        private string CityUrl(string cityName)
        {
            return $"https://weatherapi-com.p.rapidapi.com/current.json?q=q={cityName}";
        }
    }
}
