using System;

namespace Generic_Delegate
{
    public delegate T add<T>(T param1, T param2); //Generic Delegate
    class Program
    {
        static void Main(string[] args)
        {
            add<int> sum = Sum;
            Console.WriteLine(sum(10, 20));

            add<string> conct = Conact;
            Console.WriteLine(conct("Hello ", "World"));
        }

        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Conact(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
