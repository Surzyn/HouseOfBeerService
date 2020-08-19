using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOfBeerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public City GetCity()
        {
            var citiesRepo = new CitiesRepository();
            var city = citiesRepo.GetCity();
            return city;
        }

        [HttpGet("all")]
        public List<City> GetAllCities()
        {
            var citiesRepo = new CitiesRepository();
            var cities = citiesRepo.GetAllCities();
            return cities;
        }
    }
}