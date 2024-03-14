class Program
{
    static void Main(string[] args)
    {
        //derleme hataları syntaxtaki eksikliklerden kaynaklanır ve program compile edilirken hata fırlatır
        //derleme hatası, noktalı virgül eksik
        //var number = 5

        //runtime error, program çalışırken oluşan hatalardır. Try catch mantığı burada geçerlidir
        var sentence = MergeWords("A", "little", "duck", "swims", "in", "a", "pond");
        Console.WriteLine(sentence);

        //bu kod bloğu çalışma zamanı hatası fırlatır. Liste boş olduğu için atama işlemi geçersizdir
        var list = new List<int>();
        var firstElement = list.First();

        Console.ReadKey();
    }

    private static object MergeWords(params string[] words)
    {
        return string.Join("", words);
        //should be:
        //return string.Join(" ", words);
    }
}