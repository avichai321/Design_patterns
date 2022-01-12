using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    internal interface IInterirorOffice
    {
        public void AddClient();
        public void RemoveClient();
        public void ShowAllClient();
        

    }

    internal interface IServiceMachine
    {
        public void ChangeAdderess();
        public void UpdatePassport();
        public void ShowInfo();
    }
}
