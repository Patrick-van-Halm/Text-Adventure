using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TextAdventureCS
{
    class DateTime
    {
        private int timeHours;
        private int timeMin;
        private int timeSec;

        private int dateYears;
        private int dateMonths;
        private int dateDay;
        private Player p;

        public DateTime(Player player, int dateYears = 0, int dateMonths = 0, int dateDay = 0, int timeHours = 0, int timeMin = 0, int timeSec = 1)
        {
            this.dateYears = dateYears;
            this.dateMonths = dateMonths;
            this.dateDay = dateDay;

            this.timeHours = timeHours;
            this.timeMin = timeMin;
            this.timeSec = timeSec;
            this.p = player;
        }

        public void TimeCount()
        {
            Printe print = new Printe();
            print.PrinteMessageGameDate(GetDate());
            for (; this.dateYears < 66; this.dateYears++)
            {
                for(; this.dateMonths < 12; this.dateMonths++)
                {
                    for(; this.dateDay < 31; this.dateDay++)
                    {
                        for (; this.timeHours < 24; this.timeHours++)
                        {
                            for(; this.timeMin < 60; this.timeMin++)
                            {
                                for(; this.timeSec < 60; this.timeSec++)
                                {
                                    //Console.SetCursorPosition(0, 0);
                                    //Console.WriteLine("                                                                ");
                                    //Console.SetCursorPosition(0, 0);
                                    //if (this.timeHours < 10 && this.timeMin < 10)
                                    //{
                                    //    Console.WriteLine("[Year: {0} Month: {1} Day: {2} || 0{3}:0{4}:{5} ]", this.dateYears, this.dateMonths, this.dateDay, this.timeHours, this.timeMin, this.timeSec);
                                    //}
                                    //else if(this.timeHours < 10)
                                    //{
                                    //    Console.WriteLine("[Year: {0} Month: {1} Day: {2} || 0{3}:{4}:{5} ]", this.dateYears, this.dateMonths, this.dateDay, this.timeHours, this.timeMin, this.timeSec);
                                    //}
                                    //else if(this.timeMin < 10)
                                    //{
                                    //    Console.WriteLine("[Year: {0} Month: {1} Day: {2} || {3}:0{4}:{5} ]", this.dateYears, this.dateMonths, this.dateDay, this.timeHours, this.timeMin, this.timeSec);
                                    //}
                                    //else
                                    //{
                                    //    Console.WriteLine("[Year: {0} Month: {1} Day: {2} || {3}:{4}:{5} ]", this.dateYears, this.dateMonths, this.dateDay, this.timeHours, this.timeMin, this.timeSec);
                                    //}
                                    Thread.Sleep(10);
                                }
                                this.timeSec = 1;
                                print.PrinteMessageGameTime(GetTime());
                            }
                            this.timeMin = 1;
                            this.p.Hungry();
                            this.p.Tired();
                        }
                        this.timeHours = 00;
                        print.PrinteMessageGameDate(GetDate());
                    }
                    this.dateDay = 1;
                }
                this.dateMonths = 1;
            }
        }
        public string GetTime()
        {
            if(this.timeHours < 10 && this.timeMin < 10)
                return ("hour: " + "0" + this.timeHours + " | min: 0" + this.timeMin); 
            else if(this.timeHours < 10)
                return ("hour: " + "0" + this.timeHours + " | min: " + this.timeMin);
            else if(this.timeMin < 10)
                return ("hour: " + this.timeHours + " | min: 0" + this.timeMin);
            else
                return ("hour: " + this.timeHours + " | min: " + this.timeMin);
        }

        public string GetDate()
        {
            return ("Y: " + this.dateYears + " M: "+ this.dateMonths +" D: " + this.dateDay);
        }
    }
}
