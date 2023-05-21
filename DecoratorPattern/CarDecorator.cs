using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class CarDecorator:ICar
    {
        private readonly ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public abstract decimal GetDiscount();

        public decimal GetPrice()=> car.GetPrice();
      

        public string Make=>car.Make;
        
    }
}
