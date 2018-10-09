using BuilderPattern.Product;
using System;

namespace BuilderPattern
{
    public class Program
    {
        public static void Main()
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);

            Client client = new Client();
            client.ClientCode(director, builder);
        }
    }
}
