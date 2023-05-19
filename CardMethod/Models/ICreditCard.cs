using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFactoryMethod.console.Models
{
    internal interface ICreditCard
    {
        string GetCardName();
        int GetCardLimit();
        int GetAnnualCharge();
    }
}
