using BuilderPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    internal class DesktopBuilder : IComputerBuilder
    {
        ComputerSystem computer = new();
        public IComputerBuilder AddDriver(string driverSize)
        {
            computer.DriverSize = driverSize;
            return this;
        }

        public IComputerBuilder AddKeybord(string keyboadType)
        {
            computer.Keyboad=keyboadType;
            return this;
        }

        public IComputerBuilder AddMemory(string memory)
        {
            computer.RAM = memory;
            return this;
        }

        public IComputerBuilder AddMouse(string mouseType)
        {
            computer.Mounse = mouseType;
            return this;
        }

        public IComputerBuilder AddTauchCreenEnable(bool enable = false)
        {
            return this;
        }

        public ComputerSystem GetSystem()
        {
            return computer;
        }
    }
}
