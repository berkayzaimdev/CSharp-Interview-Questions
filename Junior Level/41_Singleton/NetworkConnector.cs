namespace _41_Singleton
{
    internal class NetworkConnector
    {
        private ILogger singleLoggerPerWholeApplication;

        public NetworkConnector(ILogger singleLoggerPerWholeApplication)
        {
            this.singleLoggerPerWholeApplication = singleLoggerPerWholeApplication;
        }
    }
}