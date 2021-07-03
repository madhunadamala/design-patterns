using System;

namespace AdapterPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            //Showing the Adaptee in Standard mode
            Adaptee first = new Adaptee();
            Console.WriteLine("Before the new standard\nPrecisse reading:");
            Console.WriteLine(first.SpecificRequest(5, 3));

            //What the client really wants
            ITarget second = new Adapter();
            Console.WriteLine("\nMoving to the new standard");
            Console.WriteLine(second.Request(5));
        }
    }
}
