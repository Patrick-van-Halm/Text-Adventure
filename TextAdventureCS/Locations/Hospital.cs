using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.Locations
{
    class Hospital : Location
    {
        public Hospital(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You are in the hospital.");
        }
    }
}
