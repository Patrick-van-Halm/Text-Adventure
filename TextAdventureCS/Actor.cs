﻿using System;
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
        }

        public void Tired()
        {
            this.fatigue -= 4;
        }
        public void Hungry()
        {
            this.hunger -= 4;
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
