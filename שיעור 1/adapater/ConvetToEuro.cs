using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapater
{
    internal class ConvetToEuro: Dollarpay
    {
        private Europay convert = new Europay();

        public double ConvettoDollar(double pay)
        {
            return convert.Europayment((int)pay);
        }
    }
}
