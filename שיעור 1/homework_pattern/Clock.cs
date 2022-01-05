using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_pattern
{
    public class Clock
    {
        private long Start { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        private Clock()
        {
            
        }

        private static Clock instance;
        public static Clock Getinstance()
        {
            if(instance == null)
            {
                instance = new Clock();
            } 
            return instance;
        }

       public void Gettime()
        {
            Console.WriteLine($"time stamp is: {Start}");
        }
    }
}
