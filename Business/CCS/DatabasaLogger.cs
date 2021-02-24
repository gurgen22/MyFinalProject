using System;

namespace Business.CCS
{
    public class DatabasaLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
