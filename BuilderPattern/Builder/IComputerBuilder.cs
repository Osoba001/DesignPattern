using BuilderPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public interface IComputerBuilder
    {
        IComputerBuilder AddMemory(string memory);
        IComputerBuilder AddDriver(string driverSize);

        IComputerBuilder AddKeybord(string keyboadType="none");
        IComputerBuilder AddMouse(string mouseType="none");

        IComputerBuilder AddTauchCreenEnable(bool enable=false);
        ComputerSystem GetSystem();
    }
}
