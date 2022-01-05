using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibility
{
    internal abstract class Car
    {
        public bool IsOk { get; set; }
        protected Car check;

        public void setnext(Car next)
        {
            this.check = next;
        }
        public abstract void Handle();
    }
}
