using BuilderPattern.Product;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);

            Client client = new Client();
            client.ClientCode(director, builder);
            Console.ReadLine();
        }
    }
}
