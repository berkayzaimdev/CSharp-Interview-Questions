using System;


class Program
{
    //tanımlandığı an atama yapılmalı
    // private const int ConstNumber; 

    private const int OtherConstNumber = 4;

    //derleme zamanı çalışabilen veri bulundurmalı
    // private const int ConstCurrentYear = DateTime.Now.Year; 
    //private const Person ConstPerson = new Person("John", "Smith", 1980); 

    // private static const int StaticConst = 6; //const static olarak tanımlanamaz, çünkü zaten build-in static'tir

    private readonly int ReadonlyCurrentYear = DateTime.Now.Year; //derleme ya da çalışma zamanı değere sahip olabilir.
    private readonly Person ReadonlyPerson = new Person("John", "Smith", 1980);
    private static readonly int StaticReadonly = 6;

    private readonly int ReadonlyNumber;

    //it is fine to assign readonly number at declaration
    private readonly int OtherReadonlyNumber = 4;

    public Program() //constructor
    {
        //çalışmaz çünkü const değişmez
        //ConstNumber = 5; 

        //constructor readonly ataması
        ReadonlyNumber = 10;

        //daha önce veri ataması yaptığımız senaryoda da readonly'e constructorda veri atayabiliriz
        OtherReadonlyNumber = 12;
    }

    static void Main(string[] args)
    {
        const float PI = 3.14f;
        const int DaysInWeek = 7;
        const int MaxSizeOfAnArray = 20; 
        const int BitsInByte = 8;

        // ReadonlyNumber = 20; //çalışmaz çünkü constructorda ya da tanımlamada atama yapmak zorundaydık
    }
}

class Person
{
    public string Name;
    public string LastName;
    public int YearOfBirth;

    public Person(string name, string lastName, int yearOfBirth)
    {
        Name = name;
        LastName = lastName;
        YearOfBirth = yearOfBirth;
    }
}

