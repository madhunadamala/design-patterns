using System;

namespace _07_AnonymousMethod_Delegate
{
    class Program
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            // Example - 1
            Console.WriteLine("Example - 1");
            Print print = delegate (int val)
                            {
                                Console.WriteLine("Inside Anonymous method. Value:{0}", val);
                            };
            print(100);

            //Example - 2
            Console.WriteLine("\nExample - 2");
            int i = 10;

            print = delegate (int val)
                    {
                        val += i;
                        Console.WriteLine("Anonymous method. Value: {0}", val);
                    };
            print(100);

            //Example - 3, Anonymous Method as Parameter
            Console.WriteLine("\nExample - 3, Anonymous Method as Parameter");
            PrintHelperMethod(delegate (int val) 
                                { 
                                    Console.WriteLine("Anonyms Method as Parameter. Value:{0}", val); 
                                },100
                            );
        }

        static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }

    }
}
