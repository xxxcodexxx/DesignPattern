using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Car
{
    public class Toyota : ICar
    {
        public string View()
        {
            return @"Toyota";
        }
    }
}
