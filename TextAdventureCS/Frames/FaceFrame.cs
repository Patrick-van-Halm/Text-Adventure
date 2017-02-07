using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS.Frames
{
    class FaceFrame
    {
        public FaceFrame(){
            BuildFrame();
        }
        private void BuildFrame()
        {
            Printe print = new Printe();
            for (int i = 0; i < 151; i++)
            {
                print.PrintMessage(i, 0, "═");
                print.PrintMessage(i, 37, "═");
                print.PrintMessage(i, 41, "═");
                print.PrintMessage(i, 51, "═");
            }
            for (int i = 0; i < 51; i++)
            {
                print.PrintMessage(0, i, "║");
                print.PrintMessage(151, i, "║");
            }
            print.PrintMessage(0,0, "╔");
            print.PrintMessage(0,51, "╚");
            print.PrintMessage(151,0, "╗");
            print.PrintMessage(151,51, "╝"); 
            print.PrintMessage(151, 37, "╣");
            print.PrintMessage(0, 37, "╠");
            print.PrintMessage(151, 41, "╣");
            print.PrintMessage(0, 41, "╠");
            print.PrintMessage(4,38, "╔");
            print.PrintMessage(44, 38, "╗");
            print.PrintMessage(4, 39, "║");
            print.PrintMessage(44, 39, "║");
            print.PrintMessage(4, 40, "╚");
            print.PrintMessage(44, 40, "╝");
            print.PrintMessage(54, 38, "╔");
            print.PrintMessage(94, 38, "╗");
            print.PrintMessage(54, 39, "║");
            print.PrintMessage(94, 39, "║");
            print.PrintMessage(54, 40, "╚");
            print.PrintMessage(94, 40, "╝");
            print.PrintMessage(104, 38, "╔");
            print.PrintMessage(144, 38, "╗");
            print.PrintMessage(104, 39, "║");
            print.PrintMessage(144, 39, "║");
            print.PrintMessage(104, 40, "╚");
            print.PrintMessage(144, 40, "╝");
            //vak boven
            for (int i = 0; i < 9; i++)
            {
                print.PrintMessage(111, i, "║");
            }
            for (int i = 0; i < 7; i++)
            {
                print.PrintMessage(131, i, "║");
            }
            for (int i = 111; i < 131; i++)
            {
                print.PrintMessage(i, 2, "═");
                print.PrintMessage(i, 4, "═");
            }
            for (int i = 111; i < 151; i++)
            {
                print.PrintMessage(i, 6, "═");
                print.PrintMessage(i, 8, "═");
            }
            print.PrintMessage(111, 0, "╦");
            for (int i = 2; i < 7; i+=2)
            {
                print.PrintMessage(111, i, "╠");
            }
            print.PrintMessage(131, 0, "╦");
            for (int i = 2; i < 5; i += 2)
            {
                print.PrintMessage(131, i, "╣");
            }
            print.PrintMessage(131, 6, "╩");
            print.PrintMessage(151, 6, "╣");
            print.PrintMessage(151, 8, "╣");
            print.PrintMessage(111, 8, "╚");
        }
    }
}
