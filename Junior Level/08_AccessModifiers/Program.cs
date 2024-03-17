public class TestClass
{
    public string PublicField = "public";
    internal string InternalField = "internal"; 
    protected string ProtectedField = "protected"; 
    protected internal string ProtectedInternalField = "protected internal";
    private protected string PrivateProtectedField = "private protected"; 
    private string PrivateField = "private"; 

}

class ChildOfTestClassInTheSameAssembly : TestClass
{
    public ChildOfTestClassInTheSameAssembly()
    {
        Console.WriteLine(base.PublicField);
        Console.WriteLine(base.InternalField);
        Console.WriteLine(base.ProtectedField);
        Console.WriteLine(base.ProtectedInternalField);
        Console.WriteLine(base.PrivateProtectedField);
        //Console.WriteLine(base.PrivateField); //sadece sınıfn kendisinde erişilebilir.
    }
}

class Program
{
    static void Main(string[] args)
    {
        var testClassInstance = new TestClass();

        Console.WriteLine(testClassInstance.PublicField);
        Console.WriteLine(testClassInstance.InternalField); // erişilebilir çünkü parametrenin çağrıldığı sınıf, parametrenin bulunduğu sınıf ile aynı assembly'e aittir.
        //Console.WriteLine(testClassInstance.ProtectedField); // erişilemez çünkü parametrenin çağrıldığı sınıf, parametrenin bulunduğu sınıftan kalıtım almamıştır
        Console.WriteLine(testClassInstance.ProtectedInternalField);  // erişilebilir çünkü parametrenin çağrıldığı sınıf, parametrenin bulunduğu sınıf ile aynı assembly'e aittir. İkili access modifier kullanıldığında VEYA bağlacı devreye girer

        //Console.WriteLine(testClassInstance.PrivateProtectedField);  // erişilemez çünkü ne private ne de protected şartını sağlar
        //Console.WriteLine(testClassInstance.PrivateField); //sadece parametrenin bulunduğu sınıfta çağrılabilir

        Console.ReadKey();
    }
}