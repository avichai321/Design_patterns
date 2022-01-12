using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Client client = new Client("Naruto uzumaki", 24);
            Invoice invoice = new Invoice(client, 1200, new DateTime(2021, 12, 1));
            Invoice cloneinvoice1 = invoice.clone();
            Console.WriteLine(invoice);
            
          

            Invoice cloneserial = DeepCopy<Invoice>(invoice);
            client.FullName = "avicii";
            Console.WriteLine(invoice);
            Console.WriteLine(cloneserial);

        }

        public static T DeepCopy<T>(T info)
        {
            var json = JsonSerializer.Serialize(info);
            T obj =JsonSerializer.Deserialize<T>(json);
            return obj;
        }

    }
}