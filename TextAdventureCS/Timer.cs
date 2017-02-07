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
        private int seconds;

        public Timer(int minutes = 1, int seconds = 20)
        {
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void Countdown()
        {
            for (; this.minutes > -1; this.minutes--)
            {
                for (; this.seconds > -1; this.seconds--)
                {
                    Console.Clear();
                    Console.WriteLine("{0} Minutes {1} Seconds", this.minutes, this.seconds);
                    Thread.Sleep(200);
                }
                this.seconds = 59;
            }
        }
    }
}
