using System;
class Person
{
    public int YearOfBirth
    {
        get
        {
            return _dateOfBirth.Year;
        }
        set
        {
            _dateOfBirth = new DateTime(value, _dateOfBirth.Month, _dateOfBirth.Day);
        }
    }

    private DateTime _dateOfBirth; // field
    public DateTime DateOfBirth // property
    {
        get
        {
            return _dateOfBirth;
        }
        set
        {
            if (value < DateTime.Now) //set metoduna koşul verebiliriz
            {
                _dateOfBirth = value;
            }
        }
    }

    public DateTime? DateOfDeath { get; set; }

    public int? LengthOfLife
    {
        get
        {
            return DateOfDeath == null ?
                null :
                (int)((DateOfDeath.Value - DateOfBirth).TotalDays / 365);
        }
    }
    public Person(int yearOfBirth, string lastName, string name)
    {
        YearOfBirth = yearOfBirth;
        LastName = lastName;
        Name = name;
    }

    public string Name { get; }

    private void SetName(string name)
    {
        //Name = name; //çalışmaz çünkü set için bir keyword vermedik
    }


    public string LastName { get; private set; }

    private void SetLastName(string lastName)
    {
        LastName = lastName;
    }
}


class Program
{
    static void Main(string[] args)
    {
        var person = new Person(1950, "Smith", "John");
        //çalışmaz çünkü setter metodu private ile işaretlemiştik
        //person.LastName = "Swanson"; 

        Console.ReadKey();
    }
}
