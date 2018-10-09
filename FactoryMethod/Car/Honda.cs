using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Car
{
    public class Honda : ICar
    {
        public string View()
        {
            return @"Honda";
        }
    }
}
