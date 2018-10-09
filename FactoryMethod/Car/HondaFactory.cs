namespace FactoryMethod.Car
{
    public class HondaFactory: CarFactory
    {
        public override ICar CarFactoryMethod() => new Honda();
    }
}
