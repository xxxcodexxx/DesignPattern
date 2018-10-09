using System;

namespace Prototype.Prototype
{
    public class Prototype
    {
        public Prototype() { }

        public int Primitive { get; set; }

        public DateTime Component { get; set; }

        public ComponentWithBackReference CircularReference { get; set; }

        public Prototype Clone() => CircularReference.Prototype;
    }
}
