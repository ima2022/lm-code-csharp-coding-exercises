using System;
namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person )
        {
            return person.CityofBirth == "Manchester";
        }
        public bool CanWatchFilm(Person person, int ageLimit)
        {
            return person.Age >= ageLimit;
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityofBirth { get; set; }
        public int Age { get; set; }
        public Person(string firstname, string lastname, string cityofbirth, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.CityofBirth = cityofbirth;
            this.Age = age;
        }
    }
}

