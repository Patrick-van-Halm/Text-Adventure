using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TextAdventureCS
{
    class Timer
    {
        private int minutes;

        public Timer(int minutes = 1)
        {
            this.minutes = minutes;
        }

        public void Countdown()
        {
            for (; minutes > -1; minutes--)
            {
                for (int i = 59; i > -1; i--)
                {
                    Console.Clear();
                    Console.WriteLine("{0} Minutes {1} Seconds", minutes, i);
                    Thread.Sleep(200);
                }
            }
        }
    }
}
