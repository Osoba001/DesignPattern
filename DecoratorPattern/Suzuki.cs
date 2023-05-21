using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal sealed class Suzuki : ICar
    {
        public decimal GetPrice()
        {
            return 400000;
        }

        public string Make { get { return "Suzuki Maker"; } }
        
    }
}
