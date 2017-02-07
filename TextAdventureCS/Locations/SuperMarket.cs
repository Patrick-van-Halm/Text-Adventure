using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class SuperMarket : Location
    {
        public SuperMarket(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You are standing infront of the supermarket.");
        }
    }
}
