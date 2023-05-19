using CardFactoryMethod.console.Models;

namespace CardFactoryMethod.console.CreateCardFactoryMethod
{
    internal class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new Titanium();
        }
    }
}
