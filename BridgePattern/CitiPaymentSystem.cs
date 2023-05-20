using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class CitiPaymentSystem : IPaymenentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine($"Using CitiBank gateway for {paymentSystem}");
        }
    }
}
