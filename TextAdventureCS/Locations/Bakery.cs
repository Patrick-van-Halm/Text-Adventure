using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Bakery : Location
    {
        public Bakery(string name)
            : base(name)
        {

        }

        public override void Description()
        {
            Console.WriteLine("You are standing in front of a bakery...");
        }
    }
}
