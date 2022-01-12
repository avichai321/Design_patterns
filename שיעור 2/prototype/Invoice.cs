using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    internal class Invoice
    {
        public Client client { get; set; }
        public int PriceWhoPaid { get; set; }
        public int vat { get; set; } = 17;
        public DateTime DealTime { get; set; }

        public Invoice(Client client, int bill, DateTime dealTime)
        {
            this.client = client;
            PriceWhoPaid = bill+(bill* (vat/100));         
            DealTime = dealTime;
        }
        public Invoice()
        {

        }

        public Invoice clone()
        {
            Invoice invoice = new Invoice(client/*.clone()*/, this.PriceWhoPaid, this.DealTime) ;
            return invoice;
        }
        public override string ToString()
        {
            return $"client : {client.FullName} , age: {client.age} \n deal date : {DealTime}";
        }
    }
}
