using BuilderPattern.Products;

namespace BuilderPattern.Builder
{
    public class LaptopBuilder : IComputerBuilder
    {
        public ComputerSystem computer = new();
        public IComputerBuilder AddDriver(string driverSize)
        {
            computer.DriverSize = driverSize;
            return this;
        }

        public IComputerBuilder AddKeybord(string keyboadType = "none")
        {
            return this;
        }

        public IComputerBuilder AddMemory(string memory)
        {
            computer.RAM = memory;
            return this;
        }

        public IComputerBuilder AddMouse(string mouseType = "none")
        {
            return this;
        }

        public IComputerBuilder AddTauchCreenEnable(bool enable = false)
        {
            computer.TouchScreenEnable = enable;
            return this;
        }

        public ComputerSystem GetSystem()
        {
            return computer;
        }
    }
}
