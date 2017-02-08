using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    abstract class Actor
    {
        protected string name;
        protected int maxHealth;
        protected int health;
        protected int hunger;
        protected int maxHunger;
        protected int fatigue;
        protected int maxFatigue;
        protected int money;       



        public Actor( string name)
        {
            this.name = name;
            this.maxHealth = 40;
            this.health = maxHealth;
            this.maxHunger = 40;
            this.hunger = maxHunger;
            this.maxFatigue = 40;
            this.fatigue = maxFatigue;
            this.money = 10;
            Printe printe = new Printe();
            printe.PrinteMessageGameName(name);
            printe.PrinteMassageGameHealth(this.health);
            printe.PrinteMassageGameFatigue(this.fatigue);
            printe.PrinteMassageGameHunger(this.hunger);
        }

        public void Tired()
        {
            Printe printe = new Printe();
            this.fatigue -= 4;
            printe.PrinteMassageGameFatigue(this.fatigue);
        }
        public void Hungry()
        {
            Printe printe = new Printe();
            this.hunger -= 4;
            printe.PrinteMassageGameHunger(this.hunger);
        }

        public void Sleep(DateTime DT)
        {
            Printe printe = new Printe();
            if(this.fatigue < this.maxFatigue)
            {
                DT.AddHours(8);
                int temp = this.maxFatigue - this.fatigue;
                if(8 > temp)
                {
                    this.fatigue = maxFatigue;
                    printe.PrinteMassageGameFatigue(this.fatigue);
                }
                else
                {
                    this.fatigue += 8;
                    printe.PrinteMassageGameFatigue(this.fatigue);
                }
            }
        }

        public void Eating(int healthToAdd)
        {
            Printe printe = new Printe();
            if (this.health < this.maxHealth)
            {
                int temp = this.maxHealth - this.health;
                if(healthToAdd > temp)
                {
                    this.health = this.maxHealth;
                    printe.PrinteMassageGameHealth(this.health);
                }
                else
                {
                    this.health += healthToAdd;
                    printe.PrinteMassageGameHealth(this.health);
                }
            }
        }

        public abstract void TakeHit();         

        public string GetName()
        {
            return name;
        }

        public int GetMaxHealth()
        {
            return maxHealth;
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetHunger()
        {
            return this.hunger;
        }

        public int GetMaxHunger()
        {
            return this.maxHunger;
        }

        public int GetFatigue()
        {
            return this.fatigue;
        }

        public int GetMaxFatigue()
        {
            return this.maxFatigue;
        }
       
    }
}
