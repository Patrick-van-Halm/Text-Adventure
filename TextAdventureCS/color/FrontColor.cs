using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.color
{
    class FrontColor
    {
        public FrontColor()
        {
        }
        public void setFontColor(int frontcolor)
        {
            if (frontcolor == 0)
                Console.ForegroundColor = ConsoleColor.Black;
            else if (frontcolor == 1)
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (frontcolor == 2)
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (frontcolor == 3)
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            else if (frontcolor == 4)
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            else if (frontcolor == 5)
                Console.ForegroundColor = ConsoleColor.DarkGray;
            else if (frontcolor == 6)
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            else if (frontcolor == 7)
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            else if (frontcolor == 8)
                Console.ForegroundColor = ConsoleColor.DarkRed;
            else if (frontcolor == 9)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            else if (frontcolor == 10)
                Console.ForegroundColor = ConsoleColor.Gray;
            else if (frontcolor == 11)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (frontcolor == 12)
                Console.ForegroundColor = ConsoleColor.Magenta;
            else if (frontcolor == 13)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (frontcolor == 14)
                Console.ForegroundColor = ConsoleColor.White;
            else if (frontcolor == 15)
                Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
