using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.Locations
{
    class Job : Location
    {
        public Job(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You are in the office where you work.");
        }
    }
}
