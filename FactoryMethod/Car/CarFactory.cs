namespace FactoryMethod.Car
{
    public abstract class CarFactory 
    {
        public abstract ICar CarFactoryMethod();

        public string SomeViews()
        {
            var car = CarFactoryMethod();
            var result = @"Factory: This is Car of " + car.View();
            return result;
        }
    }
}
