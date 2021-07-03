using System;

//Source: https://www.tutorialsteacher.com/csharp/csharp-delegates
namespace Delegates_Basic
{
    //declaring a delegate
    public delegate void MyDelegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Delegate calling -- START
            Console.WriteLine("BASIC DELEGATE CALL");
            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            del = ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");

            // Basic Delgate Calling -- END


            // Passing Delegate as Parameter -- START
            Console.WriteLine("\nDELEGATE AS PARAMETER");
            MyDelegate delAsParam = ClassA.MethodA;
            InvokeDelegate(delAsParam);

            delAsParam = ClassB.MethodB;
            InvokeDelegate(delAsParam);

            delAsParam = (string msg) => Console.WriteLine("Called lamda expression: " + msg);
            InvokeDelegate(delAsParam);

            // Passing Delegate as Parameter -- END

            // Multicast Delegate - START
            Console.WriteLine("\nMULTICAST DELEGATE");
            MyDelegate del1 = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodB;

            MyDelegate multiDel = del1 + del2; // combines del1 + del2
            Console.WriteLine("\nAfter del1 + del2");
            multiDel("Hello World");

            MyDelegate del3 = (string msg) => Console.WriteLine("Called lamda expression: " + msg);
            multiDel += del3; //combines del1 +del2 + del3
            Console.WriteLine("\nAfter del1 + del2 + del3");
            multiDel("Hello World");

            multiDel = multiDel - del2; // removes del2
            Console.WriteLine("\nAfter multiDel - del2");
            multiDel("Hello World");

            multiDel -= del1;
            Console.WriteLine("\nAfter multiDel - del1");
            multiDel("Hello World");
        }

        // MyDelegate Tpe Paramenter
        static void InvokeDelegate(MyDelegate delAsParam)
        {
            delAsParam("Hello World");
        }

    }
}
