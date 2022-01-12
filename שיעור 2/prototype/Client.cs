using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    internal class Client
    {
        public Client(string fullName, int age)
        {
            FullName = fullName;
            this.age = age;
        }

        public string FullName { get; set; }
        public int age  { get; set; }

        public Client clone()
        {
            Client client1 =new Client(this.FullName,this.age);
            return client1;
        }
    }
}
