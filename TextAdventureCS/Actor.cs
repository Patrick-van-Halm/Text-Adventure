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
        public void Hungry(int howMuch = 4)
        {
            Printe printe = new Printe();
            this.hunger -= howMuch;
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

        public void Eating(int foodToAdd)
        {
            Printe printe = new Printe();
            if (this.hunger < this.maxHunger)
            {
                int temp = this.maxHunger - this.hunger;
                if(foodToAdd > temp)
                {
                    this.hunger = this.maxHunger;
                    printe.PrinteMassageGameHunger(this.hunger);
                }
                else
                {
                    this.hunger += foodToAdd;
                    printe.PrinteMassageGameHunger(this.hunger);
                }
            }
        }

        public void RegenHealth()
        {
            Printe printe = new Printe();
            if(this.hunger > 29 && this.health != this.maxHealth)
            {
                this.health += 1;
                printe.PrinteMassageGameHealth(this.health);
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

        public void SetHealth(int health)
        {
            this.health = health;
        }

        public void SetFatigue(int fatigue)
        {
            this.fatigue = fatigue;
        }

        public void SetHunger(int hunger)
        {
            this.hunger = hunger;
        }
       
    }
}
