class Program
{
    //compile hatası olur. tüm değer tipleri SEALED olarak işaretlenir. (kalıtım alınamaz)
    //public class DerivedFromInt : int
    //{

    //}

    public class SpecialList : List<int> //uygun bir tanımlama. referans tipleri miras alınabilir
    {

    }

    static void Main(string[] args)
    {
        //int bir değer tipidir.
        int a = 5;
        Console.WriteLine($"Number is {a}");
        AddOne(a);
        Console.WriteLine($"Now number is {a}\n");

        //List<int> bir referans tipidir
        var list = new List<int>();
        Console.WriteLine($"List contains {list.Count} elements");
        AddOneToList(list);
        Console.WriteLine($"Now list contains {list.Count} elements\n");

        Console.WriteLine($"int's base type is {typeof(int).BaseType}");
        Console.WriteLine($"List<int>'s base type is {typeof(List<int>).BaseType}\n");

        //değer tiplerinde atama, kopyalama mantığıyla çalışır. c=b dedikten sonra c'yi değiştirmemiz b'yi etkilemez.
        int b = 10;
        int c = b;
        ++c;
        Console.WriteLine($"Number 'b' is {b}");
        Console.WriteLine($"Number 'c' is {c}\n");

        //referans tiplerinde atama adres bazında olacağı için listC'deki değişiklikler listB'yi de etkileyecektir.
        List<int> listB = new List<int> { 1, 2, 3 };
        List<int> listC = listB;
        listC.Add(4);
        Console.WriteLine($"listB contains {listB.Count} elements");
        Console.WriteLine($"listC contains {listC.Count} elements\n");

        Console.ReadKey();
    }

    private static void AddOne(int number)
    {
        //bu metod verdiğimiz parametrenin değerini değiştirmez. C'deki pointer mantığı burada da devreye giriyor
        ++number;
    }

    private static void AddOneToList(List<int> list)
    {
        //bu metod, parametre olarak atadığımız listeye 1 ekleyecektir. çünkü referans tipleri ADRES mantığıyla çalışır
        list.Add(1);
    }
}