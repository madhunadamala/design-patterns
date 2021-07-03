using System;

namespace Predicate_Delegate
{
    //Source: https://www.tutorialsteacher.com/csharp/csharp-predicate
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("hello world!");
            Console.WriteLine(result);

            //Predicate delegate with anonymous method
            Console.WriteLine("\nPredicate delegate with anonymous method");
            isUpper = delegate (string s)
                        {
                            return s.Equals(s.ToUpper());
                        };
            result = isUpper("HELLO");
            Console.WriteLine(result);

            //Predicate delegate with lambda expression
            Console.WriteLine("\nPredicate delegate with lambda expression");
            isUpper = (str1) => str1.Equals(str1.ToUpper());
            result = isUpper("hello");
            Console.WriteLine(result);

        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
