using System;

namespace Action_Delegate
{
    // Source: https://www.tutorialsteacher.com/csharp/csharp-action-delegate
    class Program
    {
        //An Action type delegate is the same as Func delegate except that the
        //Action delegate doesn't return a value.
        //In other words, an Action delegate can be used with a method that has a void return type.
        public delegate void Print(int val);
        static void Main(string[] args)
        {
            Console.WriteLine("Let us see the BASIC delegate first");
            Print print = ConsolePrint;
            print(10);

            Console.WriteLine("\nNow Action Delegate");
            Action<int> printActionDel = ConsolePrint;
            //Or
            //Action<int> printActionDel = new Action<int>(ConsolePrint);
            printActionDel(10);

            Console.WriteLine("\nAnonymous method with Action delegate");
            printActionDel = delegate (int i)
                                {
                                    Console.WriteLine(i);
                                };
            printActionDel(10);

            Console.WriteLine("\nLambda expression with Action delegate");
            printActionDel = (i) => Console.WriteLine(i);
            printActionDel(10);
        }

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
    }
}
