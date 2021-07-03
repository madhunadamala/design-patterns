using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern\n");

            IComponent component = new Component();
            Client.Display("1. Basic component: ", component);
            Client.Display("2. A-decorated : ", new DecoratorA(component));
            Client.Display("3. B-decorated : ", new DecoratorB(component));
            Client.Display("4. B-A-decorated : ", new DecoratorB(
             new DecoratorA(component)));
            // Explicit DecoratorB
            DecoratorB b = new DecoratorB(new Component());
            Client.Display("5. A-B-decorated : ", new DecoratorA(b));
            // Invoking its added state and added behavior
            Console.WriteLine("\t\t\t" + b.addedState + b.AddedBehavior());
        }
    }
}
