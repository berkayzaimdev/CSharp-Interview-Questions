//bu sınıf, namespace seviyesinde çağrıldığı için default olarak internal'dır. ya da public olabilir başka bir access modifier alamaz
class ClassAtNamespaceLevel
{
    //bu parametre, default olarak private'tır
    int number;

    public int publicNumber;


    //bu sınıf, sınıf seviyesinde çağrıldığı için default olarak private'tır
    class InnerClass
    {

    }
}

public class PublicClassAtNamespaceLevel
{
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.ReadKey();
    }
}