/*
 * new keyword'ü 3 farklı şekilde karşımıza çıkar;
 *    - 
 */

class Program
{
    static void Main(string[] args)
    {
        var pet1 = new Pet("Hannibal");
        var lazyList = new NewConstraint.LazyInitializer<List<int>>();
        //Pet class doesn't have parameterless constructor
        //var lazyPet = new NewConstraint.LazyInitializer<Pet>(); 

        Console.ReadKey();
    }
}

class NewConstraint
{
    //without this constraint, the "new T()" below would not work
    public class LazyInitializer<T> where T : new() // new modifier ile T olarak kullanmak istediğimiz nesnenin parametresiz bir constructor'a sahip olmasını zorunlu kılarız
    {
        private T value;

        public T Get()
        {
            if (value == null)
            {
                value = new T();
            }
            return value;
        }
    }
}

class Pet
{
    string Name;

    public Pet(string name)
    {
        Name = name;
    }
}