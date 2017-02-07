using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Home : Location
    {
        public Home(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in front of your home...");        }
    }
}
