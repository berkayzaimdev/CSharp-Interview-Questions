using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NewKeyword
{
    class NewOperator
    {
        public static void CreateSomeObjects()
        {
            //new operator
            var rachel = new Person("Rachel", 34); //constructor çağrıldı

            Person john = new("John", 19); //C# 9 kullanımı

            var steve = new Person { Name = "Steve", Age = 45 }; //nesne tanımlaması

            var currencies = new Dictionary<string, string> //collection tanımlaması
            {
                ["USA"] = "USD",
                ["Great Britain"] = "GBP"
            };

            var numbers = new int[4]; //dizi tanımlaması

            var person = new { Name = "Anna", Age = 55 }; //sınıfsız tanımlama 
        }
    }

    class Person
    {
        public string Name;
        public int Age;

        public Person()
        {

        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
