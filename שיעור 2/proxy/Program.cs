// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
           InteriorOffice interiorOffice = new InteriorOffice();
            ServiceMachine serviceMachine =new ServiceMachine(interiorOffice);

            interiorOffice.AddClient();
            interiorOffice.ShowAllClient();
            interiorOffice.ChangeAdderess();
            interiorOffice.ShowInfo();

            serviceMachine.UpdatePassport();
            serviceMachine.ChangeAdderess();
        }
    }
}
