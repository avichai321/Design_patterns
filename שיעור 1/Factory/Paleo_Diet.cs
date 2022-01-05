using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Paleo_Diet : IDietBase
    {
        public string DietMenu { get; set; } = "Eat just meat";
      
        
        public void GetDiet()
        {
            Console.WriteLine(DietMenu);
        }
    }
}
