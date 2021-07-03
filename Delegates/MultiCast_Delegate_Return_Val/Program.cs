using System;

namespace MultiCast_Delegate_Return_Val
{
    // Source: https://www.tutorialsteacher.com/csharp/csharp-delegates
    public delegate int MyDelegate();
    class Program
    {
        //Multicast Delegate Returning a Value
        //If a delegate returns a value,
        //then the last assigned target method's value will be return when a multicast delegate called.
        static void Main(string[] args)
        {
            MyDelegate del1 = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodB;

            MyDelegate del = del1 + del2;
            Console.WriteLine(del()); // It Returns Class B Value 200
        }
    }
}
