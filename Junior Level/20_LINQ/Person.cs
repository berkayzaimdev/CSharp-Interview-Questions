using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LINQ
{
    public class Person
    {
        public string Name;
        public string LastName;
        public int YearOfBirth;

        public Person(string name, string lastName, int yearOfBirth)
        {
            Name = name;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

        public override string ToString()
        {
            return $"{Name} {LastName} born in {YearOfBirth}";
        }
    }
}
