using System;


class Pet
{
    public string Name;
    public int Age;

    public Pet(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Person
{
    public string Name;
    public int Height;
    public Pet Pet;

    public Person(string name, int height, Pet pet)
    {
        Name = name;
        Height = height;
        Pet = pet;
    }

    public Person ShallowCopy()
    {
        return (Person)MemberwiseClone();
    }

    public Person DeepCopy()
    {
        return new Person(Name, Height, new Pet(Pet.Name, Pet.Age));
    }

    //MemberwiseClone çalışma şekli
    //public object MemberwiseClone()
    //{
    //    return new Person
    //    {
    //        Name = this.Name,
    //        Height = this.Height,
    //        Pet = this.Pet,
    //    };
    //}
}

class Program
{
    static void Main(string[] args)
    {
        var john = new Person("John", 175, new Pet("Lucky", 5));
        var johnShallowCopy = john.ShallowCopy();
        johnShallowCopy.Pet.Age = 10;
        Console.WriteLine($"John's pet age: {john.Pet.Age}");
        Console.WriteLine($"John's shallow copy's pet age: {johnShallowCopy.Pet.Age}\n");

        johnShallowCopy.Height = 150;
        Console.WriteLine($"John's height: {john.Height}");
        Console.WriteLine($"John's shallow copy's height: {johnShallowCopy.Height}\n");

        var mary = new Person("Mary", 165, new Pet("Tiger", 7));
        var maryDeepCopy = mary.DeepCopy();
        maryDeepCopy.Pet.Age = 11;
        Console.WriteLine($"Mary's pet age: {mary.Pet.Age}");
        Console.WriteLine($"Mary's deep copy's pet age: {maryDeepCopy.Pet.Age}\n");

        var person = new Person("Alex", 183, null);
        var person2 = person;
        person2.Height = 160;
        Console.WriteLine($"person's height: {person.Height}");
        Console.WriteLine($"person2's height: {person2.Height}\n");

        Console.ReadKey();
    }
}

/*
 * Deep Copy, hedef değişkenin aynısının farklı referans ile oluşturulmasını sağlar.
 * Shallow Copy ise hedef değişkenin aynısını oluşturur, fakat referans tipli değişkenleri aynı referans ile oluşturur. Yani bu yeni değişkenin referans tipli değişkenlerinde yaptığımız değişiklikler, kopyalanan değişkeni de etkiler
 
 * Shallow Copy kullanıldığında referans tipli değişkenler için hafızada yeni yer oluşturulur.
 * Bağımsız bir kopya kullanmak için Deep Copy daha iyi bir seçenek
 */
