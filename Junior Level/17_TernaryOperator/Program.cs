using System;


class Program
{
    static void Main(string[] args)
    {
        var dog = new Dog(15);

        //string size;
        //if (dog.Weight > 25)
        //{
        //    size = "big";
        //}
        //else
        //{
        //    size = "small";
        //}

        var size = dog.Weight > 25 ? "big" : "small";

        Console.WriteLine($"The dog is {size}");

        var moreSpecificSize = dog.Weight > 25 ? "big" : dog.Weight < 5 ? "small" : "medium";

        Console.WriteLine($"The dog is {moreSpecificSize}");

        //bu kod bloğu çalışmaz çünkü ternary operator'de mutlaka bir atama olmalıdır. Atama dışında return keyword ile de kullanımı mümkündür
        //dog.Weight > 100 ? 
        //    Console.WriteLine("Wow!") : 
        //    Console.WriteLine("It's a normal dog");

        Console.ReadKey();
    }
}

class Dog
{
    public int Weight;

    public Dog(int weight)
    {
        Weight = weight;
    }
}
