namespace FactoryMethod.Car
{
    public class NexusFactory : CarFactory
    {
        public override ICar CarFactoryMethod()
        {
            return new Nexus();
        }
    }
}
