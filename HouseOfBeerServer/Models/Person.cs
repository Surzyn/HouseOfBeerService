using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseOfBeerServer.Models
{
    //POCO
    public class Person
    {
        public Person()
        {

        }

        public Person(float salary)
        {
            Salary = salary;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Tel { get; set; }
        public string Email { get; set; }

        public float Salary { get; private set; }
    }
}
