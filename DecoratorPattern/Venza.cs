namespace DecoratorPattern
{
    internal sealed class Venza : ICar
    {
        public string Make => "Venza Maker";

        public decimal GetPrice()
        {
            return 900000;
        }

      
    }
}
