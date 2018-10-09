using System;
using System.Collections.Generic;

namespace BuilderPattern.Product
{
    public class Client
    {
        public void ClientCode(Director director, Builder builder)
        {
            Console.WriteLine(@"Standart basic product: ");
            //director.buildMinimalViableProduct();
            director.buildViableProduct(new List<object> { "PartA" });
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine(@"Standart full featured product: ");
            //director.buildFullFeaturedProduct();
            director.buildViableProduct(new List<object> { "PartA", "PartB", "PartC" });
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine(@"Custom product: ");
            //builder.BuildPartA();
            //builder.BuildPartC();
            builder.BuildPart(new List<object> { "PartA", "PartC"});
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}
