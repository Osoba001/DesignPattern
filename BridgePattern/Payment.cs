using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Payment
    {
        public IPaymenentSystem _paymenentSystem;
        public abstract void MakePayment();
    }
}
