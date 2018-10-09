using System.Collections.Generic;

namespace BuilderPattern.Product
{
    public class Director
    {
        Builder builder;

        public Director(Builder builder) => this.builder = builder;

        public void buildMinimalViableProduct() => builder.BuildPartA();

        public void buildFullFeaturedProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }

        public void buildViableProduct(List<object> parts) => builder.BuildPart(parts);
    }
}
