using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Printe
    {
        private int corXNull;
        private int corYNull;
        public Printe()
        {
            this.corXNull = 0;
            this.corYNull = 0;
        }
        public void PrintMessage(int corX, int corY, string message)
        {
            Console.SetCursorPosition(corX, corY);
            Console.WriteLine(message);
            Console.SetCursorPosition(corXNull, corYNull);
        }
        public void PrintMessage(int corX, int corY, string message, int backgroundColor, int frontColor)
        {
            color.BackgroundColor background = new color.BackgroundColor();
            color.FrontColor front = new color.FrontColor();
            Console.SetCursorPosition(corX, corY);
            background.setBackgroundColor(backgroundColor);
            front.setFontColor(frontColor);
            Console.WriteLine(message);
            Console.SetCursorPosition(corXNull, corYNull);
            background.setBackgroundColor(0);
            front.setFontColor(14);
        }
        public void PrintMessage(int corX, int corY, int backgroundColor, int frontColor)
        {
            color.BackgroundColor background = new color.BackgroundColor();
            color.FrontColor front = new color.FrontColor();
            Console.SetCursorPosition(corX, corY);
            background.setBackgroundColor(backgroundColor);
            front.setFontColor(frontColor);
            Console.WriteLine(' ');
            Console.SetCursorPosition(corXNull, corYNull);
            background.setBackgroundColor(0);
            front.setFontColor(14);
        }
        public void PrintClear()
        {
            for (int corX = 0; corX < 103; corX++)
            {
                for (int corY = 0; corY < 52; corY++)
                {
                    PrintMessage(corX, corY, " ");
                }
            }
        }
        public void PrintClear(int corX,int corY)
        {
            Console.SetCursorPosition(corX, corY);
            Console.WriteLine(' ');
            Console.SetCursorPosition(corXNull, corYNull);
        }
        public void PrintClear(int corX, int corY, int corX2, int corY2)
        {
            for (int X = corX; X < corX2; X++)
            {
                for (int Y = corY; Y < corY2; Y++)
                {
                    Console.SetCursorPosition(X, Y);
                    Console.WriteLine('Q');
                }
            }
            Console.SetCursorPosition(corXNull, corYNull);
        }
    }
}
