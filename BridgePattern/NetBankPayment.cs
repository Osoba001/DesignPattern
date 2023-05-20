using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class NetBankPayment : Payment
    {
        public override void MakePayment()
        {
            _paymenentSystem.ProcessPayment("NetBanking payment.");
        }
    }
}
