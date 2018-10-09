using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return @"{Result of ConcreteProduct2}";
        }
    }
}
