// See https://aka.ms/new-console-template for more information

using CardFactoryMethod.console.CreateCardFactoryMethod;
using CardFactoryMethod.console.Models;

ICreditCard moneyBack=new MoneyBackFactory().CreateProduct();

Console.WriteLine(moneyBack.GetCardName());
Console.WriteLine(moneyBack.GetAnnualCharge());
Console.WriteLine(moneyBack.GetCardLimit());
Console.WriteLine("---------------------------------");
Console.WriteLine();
ICreditCard titanium=new TitaniumFactory().CreateProduct();
Console.WriteLine(titanium.GetCardName());
Console.WriteLine(titanium.GetAnnualCharge());
Console.WriteLine(titanium.GetCardLimit());

Console.WriteLine("---------------------------------");
Console.WriteLine();
ICreditCard platinum=new PlatinumFactory().CreateProduct();
Console.WriteLine(platinum.GetCardName());
Console.WriteLine(platinum.GetAnnualCharge());
Console.WriteLine(platinum.GetCardLimit());


Console.ReadLine();
