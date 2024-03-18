using System;
using System.Collections;
using System.Linq;


class CustomCollection
{
    public string[] Words { get; }

    public CustomCollection(string[] words)
    {
        Words = words;
    }
}

class WordsCollection : IEnumerable
{
    private string[] _words;

    public WordsCollection(string[] words)
    {
        _words = words;
    }

    public IEnumerator GetEnumerator() // IEnumerable'den kalıtım aldığı için GetEnumerator kullanmak zorundayız. foreach uygulandığı zaman bu metodu çağırırız
    {
        return new WordsEnumerator(_words);
    }
}

class WordsEnumerator : IEnumerator
{
    private string[] _words;
    private int _position = -1;

    public WordsEnumerator(string[] words)
    {
        _words = words;
    }

    public object Current
    {
        get
        {
            try
            {
                return _words[_position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException("Collection end reached");
            }
        }
    }

    public bool MoveNext()
    {
        _position++;
        return _position < _words.Length;
    }

    public void Reset()
    {
        _position = -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var words = new[] { "a", "little", "duck" };

        Console.WriteLine("With foreach loop:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

        //the code above and the code below are eqivalent

        Console.WriteLine("\nWith enumerator:");
        IEnumerator wordsEnumerator = words.GetEnumerator();
        string currentWord;
        while (wordsEnumerator.MoveNext()) //enumerator dolu olduğu sürece devam et
        {
            currentWord = (string)wordsEnumerator.Current;
            Console.WriteLine(currentWord);
        }

        //çalışmaz çünkü söz konusu sınıf IEnumerable'den kalıtım almıyor
        var customCollection = new CustomCollection(words);
        //foreach(var word in customCollection)
        //{
        //    Console.WriteLine(word);
        //}

        // WordsCollection implements IEnumerable
        Console.WriteLine("\nCustom WordsCollection implementing IEnumerable:");
        var wordsCollection = new WordsCollection(words);
        foreach (var word in wordsCollection) // IEnumerable'den kalıtım aldığı için foreach uygulayabiliriz
        {
            Console.WriteLine(word);
        }

        Console.ReadKey();
    }
}
