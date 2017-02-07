using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TextAdventureCS
{
    class Timer
    {
        private int hours;
        private int minutes;
        private int seconds;
        private int sleep;
        private string sleepTheString;
        /// <summary>
        /// zet een timer
        /// </summary>
        /// <param name="interval">in seconde</param>
        public Timer(float interval)
        {
            interval *= 1000;
            if (interval % 1 == 0)
            {
                sleepTheString = interval.ToString();
                int.TryParse(sleepTheString, out this.sleep);
            }
            else
                this.sleep = 1000;
        }

        public void Countdown(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            for(; this.hours > -1; this.hours--)
            {
                for (; this.minutes > -1; this.minutes--)
                {
                    for (; this.seconds > -1; this.seconds--)
                    {
                        Console.Clear();
                        Console.WriteLine("{0} Minutes {1} Seconds", this.minutes, this.seconds);
                        Thread.Sleep(sleep);
                    }
                    this.seconds = 59;
                }
                this.minutes = 59;
            }
        }
        
    }
}
