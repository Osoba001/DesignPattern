using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class DellDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Dell();
        }

        public IComputerType ComputerType()
        {
            return new Desktop();
        }

        public IProcessor Processor()
        {
            return new I7();
        }
    }
}
