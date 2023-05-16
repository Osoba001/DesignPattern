namespace CardFactoryMethod.console.Models
{
    internal class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 6030;
        }

        public int GetCardLimit()
        {
            return 29200;
        }

        public string GetCardName()
        {
            return "Platinum";
        }
    }
}
