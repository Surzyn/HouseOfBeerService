using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseOfBeerServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseOfBeerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        Person zbysiu;

        public PersonController()
        {
            zbysiu = new Person(4001.43F)
            {
                Id = 1,
                FirstName = "Zbyszek",
                LastName = "Nowak",
                Email = "znowak@gmail.com",
                Tel = "555"
            };
        }

        [HttpGet]
        public string GetName()
        {
            return zbysiu.FirstName + " " + zbysiu.LastName;
        }


        [HttpGet("contact")]
        public string GetContact()
        {
            return $"tel: {zbysiu.Tel}, email: {zbysiu.Email}";
        }

        [HttpGet("salary")]
        public float GetSalary()
        {
            return zbysiu.Salary;
        }
    }
}