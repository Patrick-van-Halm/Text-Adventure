using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.Locations
{
    class Station : Location
    {
        public Station(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in the station.");
        }
    }
}
