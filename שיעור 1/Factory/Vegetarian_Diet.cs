using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Vegetarian_Diet : IDietBase
    {
        public string DietMenu { get; set; } = "ok you dont have friends anymore";

       
        public void GetDiet()
        {
            Console.WriteLine(DietMenu);
        }
    }
}
