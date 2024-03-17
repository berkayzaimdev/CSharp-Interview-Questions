using System;

static class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Power(double a)
    {
        return a * a;
    }
}

static class SystemMonitor
{
    private static readonly DateTime _startTime;

    static SystemMonitor()
    {
        _startTime = DateTime.UtcNow; // static 
    }
    // static constructor, özel bir yapıdır.
    //    - parametresiz olmalıdır
    //    - access modifier ile işaretlenmemelidir
    //    - overload yapılamaz
    //    - CLR tarafından, ait olduğu static class çağrıldığı ilk anda çağrılır.

    public static string Report()
    {
        return $"Monitoring the system for " +
            $"{(DateTime.UtcNow - _startTime).TotalSeconds} seconds";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // var calculator = new Calculator(); //derlenemez çünkü static sınıftan bir instance oluşturamayız
        var sum = Calculator.Add(4, 5);

        Console.WriteLine(SystemMonitor.Report());
        System.Threading.Thread.Sleep(1000); //1 saniye
        Console.WriteLine(SystemMonitor.Report());

        Console.ReadKey();
    }
}
