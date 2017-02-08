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
        private Save_Load SL;
        private bool sleep;

        public DateTime(Save_Load SL, Player player, int dateYears = 0, int dateMonths = 0, int dateDay = 0, int timeHours = 0, int timeMin = 0, int timeSec = 1)
        {
            this.dateYears = dateYears;
            this.dateMonths = dateMonths;
            this.dateDay = dateDay;

            this.timeHours = timeHours;
            this.timeMin = timeMin;
            this.timeSec = timeSec;
            this.p = player;
            this.SL = SL;
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
                                    if (sleep)
                                    {
                                        Thread.Sleep(2000);
                                        sleep = false;
                                    }
                                }
                                this.timeSec = 1;
                                print.PrinteMessageGameTime(GetTime());
                            }
                            this.timeMin = 1;
                            this.p.RegenHealth();
                            this.p.Hungry(p);
                            this.p.Tired();
                        }
                        this.timeHours = 00;
                        this.SL.Save(this, p);
                        print.PrinteMessageGameDate(GetDate());
                    }
                    this.dateDay = 1;
                }
                this.dateMonths = 1;
            }
        }
        public void Sleep()
        {
            sleep = true;
        }


        public void AddHours(int hours)
        {
            for(int i = 0; i < hours; i++)
            {
                this.p.RegenHealth();
                this.p.Hungry(p, 2);
            }
            
        }

        /*public void CheckIsAlive(Player PL, GameOver GO)
        {
            if (!PL.GetIsAlive())
            {
                GO.Run
            }
        }*/

        public void Work(int hours)
        {
            for (int i = 0; i < hours; i++)
            {
                this.p.Tired();
                this.p.RegenHealth();
                this.p.Hungry(p, 2);
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

        public int GetMins()
        {
            return this.timeMin;
        }

        public string GetDate()
        {
            return ("Y: " + this.dateYears + " M: "+ this.dateMonths +" D: " + this.dateDay);
        }

        public int GetDateY()
        {
            return this.dateYears;
        }
        public int GetDateM()
        {
            return this.dateMonths;
        }
        public int GetDateD()
        {
            return this.dateDay;
        }

        public int GetTimeH()
        {
            return this.timeHours;
        }

        public void SetDate(int dateYears, int dateMonths, int dateDays)
        {
            this.dateYears = dateYears;
            this.dateMonths = dateMonths;
            this.dateDay = dateDays;
        }

        public void SetTime(int timeHours, int timeMins)
        {
            this.timeHours = timeHours;
            this.timeMin = timeMins;
        }
    }
}
