using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Noneeddietcs : IDietBase
    {
        public string DietMenu { get; set; } = "NO NEED";

        public void GetDiet()
        {
            Console.WriteLine("no need");
        }
    }
}
