using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public interface IComputerFactory
    {
        IBrand Brand();
        IComputerType ComputerType();
        IProcessor Processor();
    }
}
