using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.color
{
    class BackgroundColor
    {
        public BackgroundColor()
        {

        }
        public void setBackgroundColor(int backgroundColor)
        {
            if (backgroundColor == 0)
                Console.BackgroundColor = ConsoleColor.Black;
            else if (backgroundColor == 1)
                Console.BackgroundColor = ConsoleColor.Blue;
            else if (backgroundColor == 2)
                Console.BackgroundColor = ConsoleColor.Cyan;
            else if (backgroundColor == 3)
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            else if (backgroundColor == 4)
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            else if (backgroundColor == 5)
                Console.BackgroundColor = ConsoleColor.DarkGray;
            else if (backgroundColor == 6)
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            else if (backgroundColor == 7)
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            else if (backgroundColor == 8)
                Console.BackgroundColor = ConsoleColor.DarkRed;
            else if (backgroundColor == 9)
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            else if (backgroundColor == 10)
                Console.BackgroundColor = ConsoleColor.Gray;
            else if (backgroundColor == 11)
                Console.BackgroundColor = ConsoleColor.Green;
            else if (backgroundColor == 12)
                Console.BackgroundColor = ConsoleColor.Magenta;
            else if (backgroundColor == 13)
                Console.BackgroundColor = ConsoleColor.Red;
            else if (backgroundColor == 14)
                Console.BackgroundColor = ConsoleColor.White;
            else if (backgroundColor == 15)
                Console.BackgroundColor = ConsoleColor.Yellow;
        }
    }
}
