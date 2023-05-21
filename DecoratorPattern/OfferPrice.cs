using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class OfferPrice : CarDecorator
    {
       
        public OfferPrice(ICar car) : base(car)
        { }

        public override decimal GetDiscount()
        {
            return .8m * GetPrice();
        }
    }
}
