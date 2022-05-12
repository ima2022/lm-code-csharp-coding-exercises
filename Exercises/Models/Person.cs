using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
    public class Person
    {
        public Person(string firstname, string lastname, string cityofbirth, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.CityofBirth = cityofbirth;
            this.Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityofBirth { get; set; }
        public int Age { get; set; }
    }
}
