using System;
namespace FactoryMethod.Car
{
    public class Boss
    {
        public void Main()
        {
            Console.WriteLine(@"Boss: Pls, show me Car of Nexus!");
            ViewCar(new NexusFactory());
            Console.WriteLine(@"Boss: Pls, Show me Car of Honda!");
            ViewCar(new HondaFactory());
            Console.WriteLine(@"Boss: Pls, Show me Car of Toyota!");
            ViewCar(new ToyotaFactory());
        }
        public void ViewCar(CarFactory carFactory) => Console.WriteLine(carFactory.SomeViews());
    }
}
