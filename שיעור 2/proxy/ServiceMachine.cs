using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class ServiceMachine : IServiceMachine
    {
        private InteriorOffice InteriorOffice;
        public ServiceMachine(InteriorOffice interiorOffice)
        {
            this.InteriorOffice = interiorOffice;
        }
        public void ChangeAdderess()
        {
            Console.WriteLine("address user change");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Show Info user" );
        }

        public void UpdatePassport()
        {
            Console.WriteLine("updated");
        }
    }
}
