using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class DellLaptopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Dell();
        }

        public IComputerType ComputerType()
        {
            return new Laptop();
        }

        public IProcessor Processor()
        {
            return new I3();
        }
    }
}
