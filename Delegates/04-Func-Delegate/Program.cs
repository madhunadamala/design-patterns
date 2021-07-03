using System;

namespace Func_Delegate
{
    // Source: https://www.tutorialsteacher.com/csharp/csharp-func-delegate
    class Program
    {

        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            // Func Delegate With Parameters
            Console.WriteLine("FUNC Delegate with input paramenters");
            Func<int, int, int> add = Sum;

            int result = add(10, 15);
            Console.WriteLine(result);

            // Func Delegate With out Parameters
            Console.WriteLine("\nFUNC Delegate without input paramenters and with Anonymous Method");
            Func<int> getRandaomNumber = delegate ()
                                        {
                                            Random rnd = new Random();
                                            return rnd.Next(1, 100);
                                        };

            result = getRandaomNumber();
            Console.WriteLine("\nRandom number: " + result);

            // Func with Lambda expression
            Console.WriteLine("\nFUNC with Lambda expression");
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            Func<int, int, int> Sum1 = (x, y) => x + y;
            Console.WriteLine(getRandomNumber());
            Console.WriteLine(Sum1(10, 20));
        }
    }
}
