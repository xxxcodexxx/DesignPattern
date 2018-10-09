namespace FactoryMethod.Car
{
    public class ToyotaFactory : CarFactory
    {
        public override ICar CarFactoryMethod() => new Toyota();
    }
}
