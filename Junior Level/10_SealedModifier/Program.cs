using System;


public class Base
{
    public virtual void DoSomething()
    {
        Console.WriteLine("Base class");
    }
}

public class Derived : Base
{
    public override sealed void DoSomething() //sealed ile işaretlenen bir method, override edilemez
    {
        Console.WriteLine("Derived class");
    }
}

public class DerivedFromDerived : Derived
{
    //bu kod bloğu derlenemez çünkü bir üst sınıfta bu metodu sealed olarak işaretlemiştik
    //public override void DoSomething() 
    //{
    //}
}

public sealed class SealedBase
{

}

//bu sınıf derlenemez çünkü bir üst sınıfı sealed olarak işaretlemiştik
//public class DerivedFromSealed : SealedBase
//{
//}

//bu sınıf derlenemez çünkü statik sınıflar default olarak sealed olarak işaretlenmiştir
//sealed static Test
//{
//}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.ReadKey();
    }
}
