using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Client
    {
        public static void Display(string s, IComponent c)
        {
            Console.WriteLine(s + c.Operation());
        }
    }
}
