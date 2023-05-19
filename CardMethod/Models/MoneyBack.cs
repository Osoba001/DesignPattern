using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFactoryMethod.console.Models
{
    internal class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 4000;
        }

        public int GetCardLimit()
        {
            return 27000;
        }

        public string GetCardName()
        {
            return "Money Back";
        }
    }
}
