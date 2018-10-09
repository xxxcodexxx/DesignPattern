using System;
using FactoryMethod.Car;
using FactoryMethod.Product;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Client().Main();
            new Boss().Main();
        }
    }
}
