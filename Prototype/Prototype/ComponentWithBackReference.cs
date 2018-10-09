namespace Prototype.Prototype
{
    public class ComponentWithBackReference
    {
        public Prototype Prototype { get; set; }

        public ComponentWithBackReference(Prototype p) => Prototype = p;
    }
}
