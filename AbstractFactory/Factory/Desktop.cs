using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class Desktop : IComputerType
    {
        public string GetComputerType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}
