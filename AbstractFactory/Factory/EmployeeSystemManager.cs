using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class EmployeeSystemManager
    {
        private readonly IComputerFactory computerFactory;

        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            this.computerFactory = computerFactory;
        }

        public string GetSystemDetail()
        {
            return $"{computerFactory.ComputerType().GetComputerType()} {computerFactory.Processor().GetProcessor()} {computerFactory.Brand().GetBrandName()}";
        }
    }
}
