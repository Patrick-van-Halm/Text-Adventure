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
            this.corXNull = 154;
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
        public void PrinteMessageGameText(string message)
        {
            int temp;
            for (int i = 1; i < 9; i++)
            {
                temp = i - 1;
                this.messageregels[temp] = this.messageregels[i];
            }
            this.messageregels[8] = message;
            PrintMessage(3, 42, messageregels[0]);
            PrintMessage(3, 43, messageregels[1]);
            PrintMessage(3, 44, messageregels[2]);
            PrintMessage(3, 45, messageregels[3]); 
            PrintMessage(3, 46, messageregels[4]);
            PrintMessage(3, 47, messageregels[5]);
            PrintMessage(3, 48, messageregels[6]);
            PrintMessage(3, 49, messageregels[7]);
            PrintMessage(3, 50, messageregels[8]);
        }
        public void PrinteMessageGameDate(string date)
        {
            PrintMessage(132, 1, date);
        }
        public void PrinteMessageGameTime(string time)
        {
            PrintMessage(132, 3, time);
        }
        public void PrinteMessageGameMoney(int money)
        {
            PrintMessage(132, 5,"money: "+ money);
        }
        public void PrinteMessageGameName(string name)
        {
            PrintMessage(132, 7, name);
        }
        public void PrinteMassageGameHealth(int health)
        {
            int corY = 39;
            int corX = 3;
            Printe print = new Printe();
            color.BackgroundColor background = new color.BackgroundColor();
            for (int i = 0; i < 40; i++)
            {
                if (health > 0)
                {
                    Console.SetCursorPosition(corX, corY);
                    background.setBackgroundColor(13);
                    Console.WriteLine(' ');
                    Console.SetCursorPosition(corXNull, corYNull);
                    background.setBackgroundColor(0);
                    health -= 1;
                    corX += 1;
                }
                else
                {
                    Console.SetCursorPosition(corX, corY);
                    background.setBackgroundColor(0);
                    Console.WriteLine(' ');
                    Console.SetCursorPosition(corXNull, corYNull);
                    background.setBackgroundColor(0);
                    corX += 1;
                }
            }
            Console.SetCursorPosition(corXNull, corYNull);
            background.setBackgroundColor(0);
            Console.WriteLine(' ');
        }
        public void PrinteMassageGameFatigue(int health)
        {
            int corY = 39;
            int corX = 54;
            Printe print = new Printe();
            color.BackgroundColor background = new color.BackgroundColor();
            for (int i = 0; i < 40; i++)
            {
                if (health > 0)
                {
                    Console.SetCursorPosition(corX, corY);
                    background.setBackgroundColor(1);
                    Console.WriteLine(' ');
                    Console.SetCursorPosition(corXNull, corYNull);
                    background.setBackgroundColor(0);
                    health -= 1;
                    corX += 1;
                }
                else
                {
                    Console.SetCursorPosition(corX, corY);
                    background.setBackgroundColor(0);
                    Console.WriteLine(' ');
                    Console.SetCursorPosition(corXNull, corYNull);
                    background.setBackgroundColor(0);
                    corX += 1;
                }
            }
            Console.SetCursorPosition(corXNull, corYNull);
            background.setBackgroundColor(0);
            Console.WriteLine(' ');
        }
        public void PrinteMassageGameHunger(int health)
        {
            int corY = 39;
            int corX = 105;
            Printe print = new Printe();
            color.BackgroundColor background = new color.BackgroundColor();
            for (int i = 0; i < 40; i++)
            {
                if (health > 0)
                {
                    Console.SetCursorPosition(corX, corY);
                    background.setBackgroundColor(15);
                    Console.WriteLine(' ');
                    Console.SetCursorPosition(corXNull, corYNull);
                    background.setBackgroundColor(0);
                    health -= 1;
                    corX += 1;
                }
                else
                {
                    Console.SetCursorPosition(corX, corY);
                    background.setBackgroundColor(0);
                    Console.WriteLine(' ');
                    Console.SetCursorPosition(corXNull, corYNull);
                    background.setBackgroundColor(0);
                    corX += 1;
                }
            }
            Console.SetCursorPosition(corXNull, corYNull);
            background.setBackgroundColor(0);
            Console.WriteLine(' ');
        }
        public void PrintClear()
        {
            
            for (int corX = 0; corX < 103; corX++)
            {
                for (int corY = 0; corY < 52; corY++)
                {
                    color.BackgroundColor background = new color.BackgroundColor();
                    Console.SetCursorPosition(corX, corY);
                    background.setBackgroundColor(0);
                    Console.WriteLine(' ');
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
