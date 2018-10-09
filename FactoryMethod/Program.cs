using System;
using FactoryMethod.Car;
using FactoryMethod.Product;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main()
        {
            //new Client().Main();
            new Boss().Main();
        }
    }
}
