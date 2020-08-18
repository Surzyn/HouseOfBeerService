using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HouseOfBeerServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Obecnie jest zimno";
        }

        [HttpGet("tomorrow")]
        public string GetForecastForTomorrow() 
        {
            return "Jutro będzie jeszcze bradziej pizgać";
        } 

        [HttpGet("location/{city}")]
        public string GetCurrentWeather(string city)
        {
            return $"W {city} jest ciepło";
        }

        [HttpGet("{lon}/{lan}")]
        public string GetCurrentWeatherForLonAndLan(double lon, double lan)
        {
            return $"W {lon}:{lan} jest mroźno";
        }
    }
}
