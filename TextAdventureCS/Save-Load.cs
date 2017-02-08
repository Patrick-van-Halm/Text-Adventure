using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TextAdventureCS
{
    class Save_Load
    {
        private string nameState;
        private int moneyState;
        private int timeHState;
        private int timeMState;
        private int dateYState;
        private int dateMState;
        private int dateDState;
        private int healthState;
        private int fatigueState;
        private int hungerState; 

        public Save_Load()
        {

        }

        public void Save(DateTime DT, Player PL)
        {
            this.nameState = PL.GetName();
            this.moneyState = PL.GetMoney();
            this.healthState = PL.GetHealth();
            this.hungerState = PL.GetHunger();
            this.fatigueState = PL.GetFatigue();
            this.dateYState = DT.GetDateY();
            this.dateMState = DT.GetDateM();
            this.dateDState = DT.GetDateD();
            this.timeHState = DT.GetTimeH();
            this.timeMState = DT.GetMins();
            try
            {
                using (StreamWriter writer = new StreamWriter("Savegame.DAT", false))
                {
                    writer.WriteLine(nameState);
                    writer.WriteLine(moneyState);
                    writer.WriteLine(healthState);
                    writer.WriteLine(hungerState);
                    writer.WriteLine(fatigueState);
                    writer.WriteLine(dateYState);
                    writer.WriteLine(dateMState);
                    writer.WriteLine(dateDState);
                    writer.WriteLine(timeHState);
                    writer.WriteLine(timeMState);

                }
            }
            catch
            {
                using (StreamWriter writer = new StreamWriter("Savegame.DAT", false))
                {}
            }
        }

        public void Load(DateTime DT, Player PL)
        {
            Printe printe = new Printe();
            using (StreamReader sr = new StreamReader("Savegame.DAT"))
            {
                string temp;
                nameState = sr.ReadLine();
                temp = sr.ReadLine();
                int.TryParse(temp, out this.moneyState);
                temp = sr.ReadLine();
                int.TryParse(temp, out this.healthState);
                temp = sr.ReadLine();
                int.TryParse(temp, out this.hungerState);
                temp = sr.ReadLine();
                int.TryParse(temp, out this.fatigueState);
                temp = sr.ReadLine();
                int.TryParse(temp, out this.dateYState);
                temp = sr.ReadLine();
                int.TryParse(temp, out this.dateMState);
                temp = sr.ReadLine();
                int.TryParse(temp, out this.dateDState);
                temp = sr.ReadLine();
                int.TryParse(temp, out this.timeHState);
                temp = sr.ReadLine();
                int.TryParse(temp, out this.timeMState);
            }
            PL.SetName(this.nameState);
            PL.SetMoney(this.moneyState);
            PL.SetHealth(this.healthState);
            PL.SetHunger(this.hungerState);
            PL.SetFatigue(this.fatigueState);
            DT.SetDate(this.dateYState, this.dateMState, this.dateDState);
            DT.SetTime(this.timeHState, this.timeMState);

            printe.PrinteMessageGameName(PL.GetName());
            printe.PrinteMassageGameFatigue(PL.GetFatigue());
            printe.PrinteMassageGameHealth(PL.GetHealth());
            printe.PrinteMassageGameHunger(PL.GetHunger());
            printe.PrinteMessageGameMoney(PL.GetMoney());
            printe.PrinteMessageGameDate(DT.GetDate());
            printe.PrinteMessageGameTime(DT.GetTime());
        }
    }
}
