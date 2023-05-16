namespace CardFactoryMethod.console.Models
{
    internal class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1420;
        }

        public int GetCardLimit()
        {
            return 80000;
        }

        public string GetCardName()
        {
            return "Titanium";
        }
    }
}
