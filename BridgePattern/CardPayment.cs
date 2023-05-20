using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class CardPayment : Payment
    {
        public override void MakePayment()
        {
            _paymenentSystem.ProcessPayment("Card payment");
        }
    }
}
