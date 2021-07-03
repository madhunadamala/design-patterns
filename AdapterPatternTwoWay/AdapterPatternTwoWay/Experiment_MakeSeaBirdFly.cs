﻿using System;

namespace AdapterPatternTwoWay
{
    class Experiment_MakeSeaBirdFly
    {
        static void Main(string[] args)
        {
            // No adapter
            Console.WriteLine("Experiment 1: test the aircraft engine");
            IAircraft aircraft = new Aircraft();
            aircraft.TakeOff();
            if (aircraft.Airborne)
            {
                Console.WriteLine("The aircraft engine is fine, flying at" +
                    aircraft.Height + "meters");
            }

            //Class usage of an adapter
            Console.WriteLine("\nExperiment 2: Use the engine in the Seabird");
            IAircraft seabird = new Seabird();
            seabird.TakeOff(); // And automatically Increases speed;
            Console.WriteLine("The Seabird took off");

            //Two-wauy adapter: using seacraft instructions on an IAircraft object
            // (where they are not in the IAircraft interface)
            Console.WriteLine("\nExperiment 3: Increase the speed of the Seabird:");
            (seabird as ISeacraft).IncreaseRevs();
            (seabird as ISeacraft).IncreaseRevs();
            if(seabird.Airborne)
            {
                Console.WriteLine("Seabird flying at height " + seabird.Height +
                    " meters and speed " + (seabird as ISeacraft).Speed + "knots");
                Console.WriteLine("Experiments successful; the Seabird flies!");
            }
        }
    }
}
