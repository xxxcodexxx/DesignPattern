using System.Collections.Generic;

namespace BuilderPattern.Product
{
    public abstract class Builder
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract void BuildPartC();

        public abstract void BuildPart(List<object> part);

        public abstract Product GetProduct();
    }
}
