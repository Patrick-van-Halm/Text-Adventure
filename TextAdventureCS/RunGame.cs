using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TextAdventureCS
{
    class RunGame
    {
        private string playerName;
        private bool pass;
        public RunGame()
        {

            // welcoms word

            // welcom ask name
            playerName = welcom();
            Console.Clear();
            // inladen alleszonder art
            Player player = new Player(playerName);
            Save_Load SL = new Save_Load();
            DateTime time = new DateTime(SL, player);
            Thread thread = new Thread(new ThreadStart(time.TimeCount));
            // start menu
            if (File.Exists("Savegame.DAT"))
            {
                Console.WriteLine("You have played this game before. do you like to go on whit this game.");
                Console.WriteLine("or do you like to start a nieuw game");
                Console.WriteLine("");
                Console.WriteLine("Press 1 to go on.");
                Console.WriteLine("Press 2 to start a nieuw game.");
                do
                {
                    var keyPress = Console.ReadKey();
                    switch (keyPress.Key)
                    {
                        case ConsoleKey.NumPad1:
                            SL.Load(time, player);
                            pass = false;
                            break;
                        case ConsoleKey.NumPad2:
                            SL.Save(time, player);
                            pass = false;
                            break;
                        default:
                            Console.WriteLine("Sorry, But you pressed the wrong key");
                            pass = true;
                            break;
                    }
                } while (pass);
            }
            else
            {
                Console.WriteLine("Good luck whit the game.");
                Console.WriteLine("And don't forget to have fun..");
                SL.Save(time, player);
            }
            // animatie met de uitleg uit santis choish systeem

            // ons huis
            LoadMap map = new LoadMap();
            map.LoadHome();
            // inladen alles
            Frames.FaceFrame frame = new Frames.FaceFrame();
            Printe print = new Printe();
            thread.Start();
            Thread.Sleep(1000);
            // loop en kies systeem hertekent als nodig

            // lopen met w,a,s,d

            // accepteren met spacie

            // cencellen met backspace

            // als je een vraag word gesteld heb je y/n

            // esc om er uit te komen

            // met pop-up
            // met opsla button

            // knop om op te slaan

            // l voor legenda

            // m voor knoppen menu

            // n voor op nieuw
            // met pop-up

            // als ecs gebruikt is doei
            // als je dood gaat dan staat er game over.
        }
        public static string welcom()
        {
            string name;
            string yOrN;
            bool pass;
            Console.WriteLine("Welcom to The Text-Aventure.");
            Console.WriteLine();
            Console.WriteLine("How do you like to be called??");
            do
            {
                pass = true;
                name = Console.ReadLine();
                Console.WriteLine("So you like to call your self {0}.", name);
                Console.WriteLine("");
                Console.WriteLine("Type: 'y' if you like your name. Or type 'n' if you don't like your name");
                yOrN = Console.ReadLine();
                if (yOrN.ToLower() == "y")
                {
                    pass = false;
                }
                else if (yOrN.ToLower() == "n")
                {
                    pass = true;
                    Console.WriteLine("How do you like to call your self than??");
                }
                else
                {
                    pass = true;
                    Console.WriteLine("Sorry, i did not understood you.");
                    Console.WriteLine("Pleas re-enter your name.");
                }
            } while (pass);
            return name;
        }
    }
}
