using CardFactoryMethod.console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFactoryMethod.console.CreateCardFactoryMethod
{
    internal class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new MoneyBack();
        }
    }
}
