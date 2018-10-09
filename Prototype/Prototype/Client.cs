using System;

namespace Prototype.Prototype
{
    public class Client
    {
        public void ClientCode()
        {
            var prototype = new Prototype();
            prototype.Primitive = 245;
            prototype.Component = new DateTime();
            prototype.CircularReference = new ComponentWithBackReference(prototype);

            var prototype2 = prototype.Clone();
            if (prototype.Primitive == prototype2.Primitive)
                Console.WriteLine("Primitive field values have been caried over to a clone.\n");
            else
                Console.WriteLine("Primitive field values have not been copied.\n");
            if (prototype.Component == prototype2.Component)
                Console.WriteLine("Simple component has been cloned.\n");
            else
                Console.WriteLine("Simple component has not been cloned.\n");
            if (prototype.CircularReference == prototype2.CircularReference)
                Console.WriteLine("Component with back reference has been cloned.\n");
            else
                Console.WriteLine("Component with back reference has not been cloned.\n");
            if (prototype.CircularReference.Prototype == prototype2.CircularReference.Prototype)
                Console.WriteLine("Component with back reference is linked to the clone.\n");
            else
                Console.WriteLine("Component with back reference is linked to original object.");
        }
    }
}
