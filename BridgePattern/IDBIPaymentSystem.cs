using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class IDBIPaymentSystem : IPaymenentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine($"Using IDBIBank gateway for {paymentSystem}");
        }
    }
}
