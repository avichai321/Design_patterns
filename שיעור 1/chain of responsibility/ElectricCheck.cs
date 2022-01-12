using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibility
{
    internal class ElectricCheck : Car
    {

        public override void Handle()
        {
            int grade = new Random().Next(1, 11);
            if (grade >= 6)
            {
                IsOk = true;
                Console.WriteLine("The Car is OK");
            }
            else
            {
                if (check != null)
                {
                    Console.WriteLine("failed Electric Check");
                    check.Handle();
                }
            }
        }
    }
}
