using System;


class Program
{
    private static void AddOne(int a)
    {
        Console.WriteLine($"Calling AddOne function");
        ++a;
    }

    private static void AddOneByRef(ref int a)
    {
        Console.WriteLine($"Calling AddOneByRef function");
        ++a;
    }

    private static bool TryParseToInt(string input, out int result)
    {
        try
        {
            result = int.Parse(input);
            return true;
        }
        catch
        {
            result = 0;
            return false;
        }
    }

    //private static bool TryParseToDouble(string input, out double result)
    //{
    //    try
    //    {
    //        result = double.Parse(input);
    //        return true;
    //    }
    //    catch
    //    {
    //        //burada result ataması yapılmalıydı. result, bu fonksiyonda return gibi mutlaka verilmeliydi o yüzden hata alırız
    //        return false;
    //    }
    //}

    static void Main(string[] args)
    {
        Console.WriteLine("---REF---\n");

        var number = 10;
        Console.WriteLine($"number is {number}");
        AddOne(number);
        Console.WriteLine($"number is still {number}\n");

        AddOneByRef(ref number);
        Console.WriteLine($"now number is {number}");

        int uninitializedValue;
        //AddOneByRef(ref uninitializedValue); //çalışmaz çünkü ref kullanımında tipin değer ataması yapılmış olmalı

        Console.WriteLine();
        Console.WriteLine("---OUT---");
        var validInput = "1";

        bool wasParsingSuccessful = TryParseToInt(validInput, out int result);

        int variableForResult; // çalışmaz çünkü out ilk kullılmalıydı ve int ile işaretlenmeliydi
        bool wasParsingSuccessful2 = TryParseToInt(validInput, out variableForResult);

        PrintParsingResult(validInput, wasParsingSuccessful, result);


        var invalidInput = "rubbish";
        bool wasParsingOfRubbishSuccessful = TryParseToInt(invalidInput, out int rubbishResult);
        PrintParsingResult(invalidInput, wasParsingOfRubbishSuccessful, rubbishResult);

        Console.ReadKey();
    }

    private static void PrintParsingResult(string input, bool wasParsingSuccessful, int result)
    {
        if (wasParsingSuccessful)
        {
            Console.WriteLine($"Successfully parsed \"{input}\" to int {result}");
        }
        else
        {
            Console.WriteLine($"Could not parse \"{input}\" to int, result is {result}");
        }
    }
}
