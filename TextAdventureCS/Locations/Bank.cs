using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.Locations
{
    class Bank : Location
    {
        public Bank(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You are in the bank.");
        }
    }
}
