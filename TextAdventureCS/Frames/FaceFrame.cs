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
        public void BuildFrame()
        {
            Printe print = new Printe();
            for (int i = 0; i < 151; i++)
            {
                print.PrintMessage(i, 0, "═");
                print.PrintMessage(i, 27, "═");
                print.PrintMessage(i, 31, "═");
                print.PrintMessage(i, 41, "═");
            }
            for (int i = 0; i < 41; i++)
            {
                print.PrintMessage(0, i, "║");
                print.PrintMessage(151, i, "║");
            }
            print.PrintMessage(0,0, "╔");
            print.PrintMessage(0,41, "╚");
            print.PrintMessage(151,0, "╗");
            print.PrintMessage(151,41, "╝"); 
            print.PrintMessage(151, 27, "╣");
            print.PrintMessage(0, 27, "╠");
            print.PrintMessage(151, 31, "╣");
            print.PrintMessage(0, 31, "╠");

            print.PrintMessage(2,28, "╔");
            print.PrintMessage(43, 28, "╗");
            print.PrintMessage(2, 29, "║");
            print.PrintMessage(43, 29, "║");
            print.PrintMessage(2, 30, "╚");
            print.PrintMessage(43, 30, "╝");
            print.PrintMessage(53, 28, "╔");
            print.PrintMessage(94, 28, "╗");
            print.PrintMessage(53, 29, "║");
            print.PrintMessage(94, 29, "║");
            print.PrintMessage(53, 30, "╚");
            print.PrintMessage(94, 30, "╝");
            print.PrintMessage(104, 28, "╔");
            print.PrintMessage(145, 28, "╗");
            print.PrintMessage(104, 29, "║");
            print.PrintMessage(145, 29, "║");
            print.PrintMessage(104, 30, "╚");
            print.PrintMessage(145, 30, "╝");
            //vak boven
            for (int i = 0; i < 9; i++)
            {
                print.PrintMessage(131, i, "║");
            }
            for (int i = 0; i < 7; i++)
            {
                print.PrintMessage(151, i, "║");
            }
            for (int i = 131; i < 151; i++)
            {
                print.PrintMessage(i, 2, "═");
                print.PrintMessage(i, 4, "═");
            }
            for (int i = 131; i < 151; i++)
            {
                print.PrintMessage(i, 6, "═");
                print.PrintMessage(i, 8, "═");
            }
            print.PrintMessage(131, 0, "╦");
            for (int i = 2; i < 7; i+=2)
            {
                print.PrintMessage(131, i, "╠");
            }
            print.PrintMessage(151, 0, "");
            for (int i = 2; i < 5; i += 2)
            {
                print.PrintMessage(151, i, "╣");
            }
            print.PrintMessage(151, 0, "╗");
            print.PrintMessage(151, 6, "╣");
            print.PrintMessage(151, 8, "╣");
            print.PrintMessage(131, 8, "╚");
        }
    }
}
