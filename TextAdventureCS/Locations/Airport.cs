using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.Locations
{
    class Airport : Location
    {
        public Airport(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You are at the airport...");
        }
    }
}
