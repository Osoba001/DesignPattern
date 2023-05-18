using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class Dell : IBrand
    {
        public string GetBrandName()
        {
            return Brands.Dell.ToString();
        }
    }
}
