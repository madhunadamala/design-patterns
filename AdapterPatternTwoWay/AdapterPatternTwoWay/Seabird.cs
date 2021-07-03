﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternTwoWay
{
    // Adapter
    public class Seabird : Seacraft, IAircraft
    {
        int height = 0;

              
        // A two-way adapter hides and routes the Target's methods
        // Use Seacraft instructions to implement this one
        public void TakeOff()
        {
            while (!Airborne)
            {
                IncreaseRevs();
            }
        }


        // Routes this straight back to the Aircraft
        public int Height
        {
            get => height;
        }

        // This method is common to both Target and Adaptee
        public override void IncreaseRevs()
        {
            base.IncreaseRevs();
            if (Speed > 40)
            {
                height += 100;
            }
        }

        public bool Airborne
        {
            get { return height > 50; }
        }

    }
}
