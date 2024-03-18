using System;
using System.Collections.Generic;

namespace MethodOverloading
{
    class Program
    {

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Add(ref int a, ref int b)
        {
            return a + b;
        }

        //ref ya da out kullanabiliriz ancak ikisini aynı anda kullanamayız.
        //private static int Add(ref int a, out int b)
        //{
        //    return a + b;
        //}

        //derlenemez çünkü parametre alanı aynıdır. parametre alanı mutlaka farklı olmalıdır geçerli bir overload için
        //private static string Add(int a, int b) 
        //{
        //    return a.ToString() + b.ToString();
        //}

        private static string Add(string a, string b)
        {
            return a + b;
        }

        private static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        private static void Add(List<int> list, int newElement)
        {
            list.Add(newElement);
        }

        private static void Add(int newElement, List<int> list)
        {
            list.Add(newElement * 2);
        }

        private static void TestMethod(int a)
        {
            Console.WriteLine("calling method without optional parameter.");
        }

        private static void TestMethod(int a, int b = 0)
        {
            Console.WriteLine("calling method with optional parameter.");
        }

        static void Main(string[] args)
        {
            //var someInt = Add(1, 2);
            //var someString = Add(1, 2); //var kullanmasaydık çalışırdı. dönüş değerine göre değişkeni işaretlerdik

            TestMethod(5); // tek parametreli method çalışır
            TestMethod(5,6); // opsiyonel parametreli method çalışır

            Console.ReadKey();
        }
    }
}