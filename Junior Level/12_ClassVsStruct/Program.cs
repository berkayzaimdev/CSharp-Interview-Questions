using System;


struct Point
{
    public int x;
    public int y;

    //derlenemez çünkü tek bir constructor olabilir ve o constructor tüm parametreleri içermelidir
    //public Point()
    //{

    //}
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.ReadKey();
    }
}

/* 
 * Struct'lar hangi durumlarda kullanılmalıdır?
 *    - Tip, minimal boyuttaysa
 *    - Tip, değiştirilemez ise
 *    - Tip, kısa ömürle kullanılacak ise
 *    - Tip, diğer nesnelerle etkileşimde olacaksa


  
 * Struct vs Class,
 *    - Structlar değer tipidir, class ise referans tipidir
 *    - Struct tek bir constructor içerir
 *    - Struct, destructor içeremez
*/