﻿public static class StringExtensions
{
    public static int NumberOfLines(this string input)
    {
        return input.Split("\n").Length;
    }
}

public class Duck
{
    //public string Quack()
    //{
    //    return "(Not an extension method) Quack, quack, I'm a duck";
    //}
}

public static class DuckExtensions
{
    public static string Quack(this Duck duck)
    {
        return "(This is an extension method) Quack, quack, I'm a duck";
    }
}

class Program
{
    static void Main(string[] args)
    {

        var multilineString = @"Said the Duck to the Kangaroo,
                                    Good gracious! how you hop
                                    Over the fields, and the water too,
                                    As if you never would stop!
                                    My life is a bore in this nasty pond;
                                    And I long to go out in the world beyond:
                                    I wish I could hop like you,
                                    Said the Duck to the Kangaroo.";

        var numberOfLines = multilineString.NumberOfLines();

        Console.WriteLine($"Number of lines is {numberOfLines}\n");

        var duck = new Duck();
        // Method overload edilmiş ise öncelik sınıfın kendi metodundadır
        Console.WriteLine(duck.Quack());

        Console.ReadKey();
    }
}

/*
 * Extension methodlar, sınıfa sınıfı değiştirmeden ve sınıfa kalıtım vermeden fonksiyonalite katan methodlardır.
 * Extension method yazılan sınıfı tekrar derlememiz gerekmez.
 * Extension methodları, extend edilen sınıfın bir metodu gibi kullanırız.
 * 
 * Extension method olma koşulu methodları barındıran sınıfın static olması ve methodlarda this keyword içermesidir
 */