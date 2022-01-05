using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factory
{
    public static class DietFactory
    {
        public static IDietBase GetDietnow(int age, double weight, double height)
        {
            double bmi = weight / Math.Pow(height, 2);

            if (age>30 && (bmi >= 22 && bmi< 28.9)) 
            {
                return new Paleo_Diet();
            }
            else if (age> 40 && (bmi >= 34.5 && bmi< 37.4))
            {
                return new Etkines_Diet();
            }
            else if(age>40 &&bmi >= 37.4)
            {
                return new Vegetarian_Diet();
            }
            return new Noneeddietcs();
         

           

        }

    }
}
