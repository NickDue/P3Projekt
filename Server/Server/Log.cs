using Org.BouncyCastle.Tsp;

namespace Server
{
    public class Log
    {
        public string WorkerID { get; }
        public string ProductId { get; }
        public string Message { get; }
        public string Date { get; }

        public Log(string wId, string productId, string message, string date)
        {
            WorkerID = wId;
            ProductId = productId;
            Message = message;
            Date = date;
        }

        public string LogToString()
        {
            return $"{WorkerID}!{ProductId}!{Message}!{Date}";
        }
    }
}