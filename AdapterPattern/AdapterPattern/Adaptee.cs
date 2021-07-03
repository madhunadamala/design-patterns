using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // Existing way requests are implemented.
    // Assuming it is a legacy code and need to be used in new systems.
    class Adaptee
    {
        // Provide full precision
        public double SpecificRequest(double a, double b)
        {
            return a/ b;
        }
    }
}
