namespace AbstractFactory.Product
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return @"The result of the product A1";
        }
    }
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return @"The result of the product A2";
        }
    }
}
