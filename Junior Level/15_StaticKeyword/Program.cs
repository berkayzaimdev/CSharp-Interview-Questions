class Box
{
    public static int MaxCount = 50;

    private List<string> elements = new List<string>();

    public void Add(string element)
    {
        if (elements.Count < MaxCount)
        {
            elements.Add(element);
        }
    }

    //bu metodu static olarak işaretleyemeyiz çünkü dönüş değeri static olmayan bir ifade barındırıyor
    public int GetCurrentCount()
    {
        return elements.Count;
    }

    public static string FormatMaxCount()
    {
        return $"The max count for this Box is {MaxCount}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var box1 = new Box();
        var box2 = new Box();
        //var invalidMaxCount = box1.MaxCount; //static parametreyi kullanabilmek için instance değil tip parametresinden faydalanırız
        var maxCount = Box.MaxCount;
        box2.Add("s");
        var elementsCount = box2.GetCurrentCount();
        var maxCountFormatted = Box.FormatMaxCount();

        Console.ReadKey();
    }
}