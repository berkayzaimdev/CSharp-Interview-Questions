//class Duck
//{
//    private void Quack()
//    {
//        Console.WriteLine("Quack, quack, I'm a duck");
//    }

//    public void Fly()
//    {
//        Console.WriteLine("Flying high in the sky");
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.ReadKey();
    }
}

/*
 * Partial class'lar; birden fazla partial ile işaretlenip aynı isimlendirmeye sahip sınıfın derleme esnasında birleştirildiği ve tek bir class gibi kullanılabilen yapıtaşlarıdır.
 * 
 * Fly metodu, PartOne'deki haliyle bırakılırsa çalışmayacaktı çünkü bir sınıfta boş metod tanımlanamaz.
 * Fly metodu, PartTwo'da içinin doldurulmasıyla anlam kazandı ve kullanılabilir hale geldi.
 */