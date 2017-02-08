using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class LoadPop_Up
    {
        private string question;

        public LoadPop_Up()
        {
            
        }

        public void PopUp(string question)
        {
            Printe printe = new Printe();
            this.question = question;
            printe.PrintMessage(50, 15, this.question, 14, 13);
            printe.PrintMessage(50, 16, "1. Yes", 14, 13);
            printe.PrintMessage(50, 17, "1. No", 14, 13);
        }
    }
}
