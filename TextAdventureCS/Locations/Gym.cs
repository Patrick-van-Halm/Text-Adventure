using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.Locations
{
    class Gym : Location
    {
        public Gym(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You are standing infront of the gym");
        }
    }
}
