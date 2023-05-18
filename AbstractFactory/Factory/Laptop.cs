using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class Laptop : IComputerType
    {
        public string GetComputerType()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }
}
