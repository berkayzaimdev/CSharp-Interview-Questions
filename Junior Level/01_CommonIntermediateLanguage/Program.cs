class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! What's your name?");
        var name = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {name}. How old are you?");

        var ageAsText = Console.ReadLine();

        if (int.TryParse(ageAsText, out int age))
        {
            Console.WriteLine($"That young, only {age}?");
        }
        else
        {
            Console.WriteLine("Sorry, I didn't get that.");
        }
        Console.WriteLine("Well, it was nice to meet you! Bye, bye!");
        Console.ReadKey();
    }
}

/*
 * 
 
 * .NET tabanlı diller; C#, F# ve Visual Basic olarak karşımıza çıkmaktadır.
 * Bu diller, program koşturulmaya çalışıldığı anda kendi compiler'ları aracılığıyla CIL adı verilen bir koda dönüştürülürler.
 * Bu CIL kodları, programın bulunduğu dizinde /bin altdizini altında .dll formatıyla tutulurlar. 
 
 * Ildasm adı verilen .NET'e dahili gelen bir yazılım sayesinde bu .dll dosyasını açabilir ve CIL kodları görebiliriz.
 
 * CIL kodları Just-in-Time compiler aracılığıyla makine kodlarına dönüştürülür. Bu kodlar, bilgisayarın anlayabileceği ham formattadır.
 
 * Soru 1: Bir C# sınıfı nasıl F# sınıfından kalıtım alabilir?
 * - İkisi de .NET tabanlı olduğu için bu diller arası CIL kodu aracılığıyla bağlantı kurulabilir

 * Soru 2: JIT compiler, çalışma zamanında mı çalışır, derleme zamanında mı?
 * - Çalışma zamanında çalışır
 
 * 
 */