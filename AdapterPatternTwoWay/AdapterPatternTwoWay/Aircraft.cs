using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTwoWay
{
    public sealed class Aircraft : IAircraft
    {
        bool airborne;

        int height;

        public Aircraft()
        {
            height = 0;
            airborne = false;
        }

        public bool Airborne
        {
            get => airborne;
        }

        public int Height
        {
            get => height;
        }
        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            airborne = true;
            height = 200; // Meters
        }
    }
}
