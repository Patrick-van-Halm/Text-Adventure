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

        public void PopUpYN(string question)
        {
            Printe printe = new Printe();
            this.question = question;
            if(this.question.Length > 34)
            {
                printe.PrintMessage(58, 8, this.question.Substring(0, 34), 14, 13);
                printe.PrintMessage(58, 9, this.question.Substring(34), 14, 13);
                printe.PrintMessage(70, 11, "Yes | No", 14, 13);
            }
            else
            {
                printe.PrintMessage(58, 8, this.question, 14, 13);
                printe.PrintMessage(70, 9, "Yes | No", 14, 13);
            }
        }
    }
}
