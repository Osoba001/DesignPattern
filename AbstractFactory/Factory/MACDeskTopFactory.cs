using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class MACDeskTopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IComputerType ComputerType()
        {
            return new Desktop();
        }

        public IProcessor Processor()
        {
            return new I5();
        }
    }
}
