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
        string[] messageregels = new string[10];
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
        public void PrinteMessageGame(string message)
        {
            string temp;
            for (int i = 1; i < 10; i++)
            {
                this.messageregels[i--] = this.messageregels[i];
            }
            this.messageregels[9] = message;
            PrintMessage(3, 40, messageregels[0]);
            PrintMessage(3, 41, messageregels[1]);
            PrintMessage(3, 42, messageregels[2]);
            PrintMessage(3, 43, messageregels[3]); 
            PrintMessage(3, 44, messageregels[4]);
            PrintMessage(3, 45, messageregels[5]);
            PrintMessage(3, 46, messageregels[6]);
            PrintMessage(3, 47, messageregels[7]);
            PrintMessage(3, 48, messageregels[8]);
            PrintMessage(3, 49, messageregels[9]);
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
