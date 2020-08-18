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
        static Person[] people = new Person[3]
        {
            new Person(4001.43F)
            {
                Id = 1,
                FirstName = "Zbyszek",
                LastName = "Nowak",
                Email = "znowak@gmail.com",
                Tel = "555"
            },
            new Person(3333)
             {
                Id = 2,
                    FirstName = "Alicja",
                    LastName = "Kowalska",
                    Email = "akowal@gmail.com",
                    Tel = "6666"
             },
            new Person(6666)
            {
                Id = 10,
                    FirstName = "Bob",
                    LastName = "Lis",
                    Email = "blis@lis.pl",
                    Tel = "111111"
            }
        };

        [HttpGet]
        public string Ping()
        {
            return "Pong";
        }

        [HttpPost]
        public int AddPerson()
        {
            return 100;
        }

        [HttpPut("{id}")]
        public bool EditPerson(int id)
        {
            foreach (Person p in people)
            {
                if (p.Id == id)
                {
                    p.FirstName = "Burger";
                    return true;
                }
            }

            return false;
        }

        [HttpGet("{id}")]
        public string GetName(int id)
        {
            foreach (Person person in people)
            {
                if (person.Id == id)
                {
                    return person.FirstName + " " + person.LastName;
                }
            }

            return "Nie znaleziono osoby o danym id";
        }


        [HttpGet("contact/{id}")]
        public string GetContact(int id)
        {
            foreach (Person p in people)
            {
                if (p.Id == id)
                {
                    return $"tel: {p.Tel}, email: {p.Email}";
                }
            }

            return $"Nie znaleziono osoby o danym id: {id}";
        }

        [HttpGet("salary")]
        public float GetSalary()
        {
            return people[0].Salary;
        }

        [HttpGet("totalSalary")]
        public float GetTotalSalary()
        {
            float sum = 0;
            foreach (Person p in people)
            {
                sum += p.Salary;
            }

            return sum;
        }


    }
}