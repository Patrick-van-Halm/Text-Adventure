using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Fabric : Location
    {
        public Fabric(string name)
            : base(name)
        {
          
        }

        public override void Description()
        {
            // Insert a nice description
            Console.WriteLine("You are standing in front of the fabric...");
        }
    }
}
