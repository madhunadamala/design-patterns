using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTwoWay
{
    // Two-Way Adapter Pattern
    // Embedded system for a Seabird flying plane
    // ITarget interface
    public interface IAircraft
    {
        bool Airborne { get; }
        void TakeOff();
        int Height { get; }
    }
}
