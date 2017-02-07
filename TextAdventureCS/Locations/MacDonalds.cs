using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.Locations
{
    class MacDonalds : Location
    {
        public MacDonalds(string name)
            : base(name)
        {
        }

        public override void Description()
        {
            Console.WriteLine("You are standing in the Mac Donalds here you can get the best fastfood");
        }
    }
}
