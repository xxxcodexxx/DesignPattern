namespace FactoryMethod.Car
{
    public class ToyotaFactory : CarFactory
    {
        public override ICar CarFactoryMethod()
        {
           return new Toyota();
        }
    }
}
