using System;

class Program
{
    //bu kod bloğu derlenemez. çünkü params keyword'ü sadece en son parametreye uygulanabilir
    //static void SomeFunction(params int[] numbers, int multiplier, params[] otherNumber)
    //{

    //}

    //bu kod bloğu derlenemez. çünkü params keyword'ü sadece tek boyutlu dizi ile kullanılabilir
    //static void SomeFunction(params List<int> numbers)
    //{

    //}

    static int ClumsySum(int[] numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static int Sum(params int[] numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");

        ClumsySum(new[] { 1, 2 });
        ClumsySum(new[] { 1, 2, 3, 4 });
        ClumsySum(new int[] { });

        //daha şık bir syntax elde ederiz
        Sum(1, 2);
        Sum(1, 2, 3, 4);
        Sum();

        Console.ReadKey();
    }
}
