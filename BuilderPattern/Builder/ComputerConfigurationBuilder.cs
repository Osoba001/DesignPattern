using BuilderPattern.Products;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    internal static class ComputerConfigurationBuilder
    {
        public static void ComputerBuilder(IComputerBuilder computerBuilder, string memory,string ramSize,bool touchScrean, string mouse="none",string keyboad="none")
        {
            computerBuilder.AddMemory(memory)
            .AddDriver(ramSize)
            .AddTauchCreenEnable(touchScrean)
            .AddMouse(mouse)
            .AddKeybord(keyboad);
        }
        
    }
}
