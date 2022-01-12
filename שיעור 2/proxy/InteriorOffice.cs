using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal class InteriorOffice : IInterirorOffice, IServiceMachine
    {

        public void AddClient()
        {
            Console.WriteLine("Client added");
        }

        public void ChangeAdderess()
        {
            Console.WriteLine("Change Address");
        }

        public void RemoveClient()
        {
            Console.WriteLine("Client removed");
        }

        public void ShowAllClient()
        {
            Console.WriteLine("show all client");
        }

        public void ShowInfo()
        {
            Console.WriteLine("show infoall");
        }

        public void UpdatePassport()
        {
            Console.WriteLine("passport updated");
        }
    }
}
