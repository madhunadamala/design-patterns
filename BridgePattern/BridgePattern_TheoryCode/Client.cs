using System;

namespace BridgePattern_TheoryCode
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern\n");
            Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
            Console.WriteLine(new Abstraction(new ImplementationB()).Operation());

        }
    }
}
