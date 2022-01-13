// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VacationBuilder vacation1 = new LowCostVacation();
            vacation1.CreateVacation();
            Vacation vacation2 = vacation1.GetVacation();
            Console.WriteLine(vacation2);

            VacationFluentBuilder vacationFluent = new VacationFluentBuilder();
            VacationFluent vacationFluent1 = vacationFluent.GetRoomInsweata().GetRideOnlimo().GetBusinessFlight().Build();
                                            

        }
    }
}
