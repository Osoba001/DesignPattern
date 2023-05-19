// See https://aka.ms/new-console-template for more information

using BuilderPattern.Builder;
using BuilderPattern.Products;

IComputerBuilder desktop = new DesktopBuilder();


ComputerConfigurationBuilder.ComputerBuilder(desktop,"1TB","8G",true,"Logitech Mounse","Logitech Keyboard");

ComputerSystem computer = desktop.GetSystem();

Console.WriteLine($"Keyboad: {computer.Keyboad}, DriverSize: {computer.DriverSize}, Mouse: {computer.Mounse},TouchScreenEnable: {computer.TouchScreenEnable}");
Console.WriteLine($"---------------------------------------------");


IComputerBuilder laptop = new LaptopBuilder();
ComputerConfigurationBuilder.ComputerBuilder(laptop, "1TB", "8G", true, "Logitech Mounse", "Logitech Keyboard");
computer = laptop.GetSystem();

Console.WriteLine($"Keyboad: {computer.Keyboad}, DriverSize: {computer.DriverSize}, Mouse: {computer.Mounse},TouchScreenEnable: {computer.TouchScreenEnable}");
Console.ReadLine();
