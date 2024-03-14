class Program
{
    static void Main(string[] args)
    {
        //burada boxing yapılmamış çünkü string bir referans tipidir
        string word = "abc";
        object obj = word;

        //boxing ve unboxing işlemleri
        int number = 5;
        object boxedNumber = number;
        int unboxedNumber = (int)boxedNumber;

        //bu kod bloğu hata fırlatacaktır çünkü unboxing işlemi, tip uyumu gerektirir
        /*
        short shortNumber = 3;
        object boxedShortNumber = shortNumber;
        int unboxedShortNumber = (int)boxedShortNumber;         
        */


        //burada standart bir tip dönüşümü yapıldığı için tip uyumu gerekmez ve kod çalışır
        short otherShortNumber = 3;
        int otherShortNumberCastToInt = (int)otherShortNumber;

        Console.ReadKey();
    }
}