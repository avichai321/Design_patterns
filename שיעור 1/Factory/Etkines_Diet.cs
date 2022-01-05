using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Etkines_Diet : IDietBase
    {
        public string DietMenu { get; set; } = "okay you are lost";

      
        public void GetDiet()
        {
            Console.WriteLine(DietMenu);
        }
    }
}
