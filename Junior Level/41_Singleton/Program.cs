using System;

namespace _41_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //singleton design pattern
            var singleton = Singleton.Instance;
            var nextSingleton = Singleton.Instance;
            Console.WriteLine($"singleton: {singleton.Id}");
            Console.WriteLine($"nextSingleton: {nextSingleton.Id}");

            //uygulama singleton'ı. ayrıntılı olarak .NET Core'dan aşinayız
            var singleLoggerPerWholeApplication = new Logger();
            var database = new Database(singleLoggerPerWholeApplication);
            var networkConnector = new NetworkConnector(singleLoggerPerWholeApplication);
            var interfaceHandler = new InterfaceHandler(singleLoggerPerWholeApplication);

            RunApplication(database, networkConnector, interfaceHandler);

            Console.ReadKey();
        }

        private static void RunApplication(
            Database database,
            NetworkConnector networkConnector, 
            InterfaceHandler interfaceHandler)
        {
            //run application
        }
    }

    public sealed class Singleton
    {
        private static Singleton instance = null;
        public string Id { get; }

        private Singleton() // private ve boş bir constructor, singleton için olmazsa olmaz tanımlamadır
        {
            Id = Guid.NewGuid().ToString();
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
