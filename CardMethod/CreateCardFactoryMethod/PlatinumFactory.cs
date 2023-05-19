using CardFactoryMethod.console.Models;

namespace CardFactoryMethod.console.CreateCardFactoryMethod
{
    internal class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new Platinum();
        }
    }
}
