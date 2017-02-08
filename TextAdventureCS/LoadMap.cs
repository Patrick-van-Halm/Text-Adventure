using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TextAdventureCS;

namespace TextAdventureCS
{
    class LoadMap
    {
        private string pathCity;
        private string pathBar;
        private string pathPopup;
        private string pathSuper;
        private string map;
        private int lengtCor;
        private char cut;
        private string[] cor;
        private string[] corString;
        private int[] corInt;
        public LoadMap()
        {
            this.pathBar = @"maps\bar.txt";
            this.pathPopup = @"maps\popup.txt";
            this.pathSuper = @"maps\suprmarkt.txt";
            this.pathCity = @"maps\map.txt";
            this.cut = ',';
        }
        public void LoadCity()
        {
            map = File.ReadAllText(pathCity);
            CutMap();
        }
        public void LoadBar()
        {
            map = File.ReadAllText(pathBar);
            CutMap();
        }
        public void LoadPopup(string question)
        {
            LoadPop_Up pop = new LoadPop_Up();
            map = File.ReadAllText(pathPopup);
            CutMap();
            pop.PopUpYN(question);
        }
        public void LoadSuper()
        {
            map = File.ReadAllText(pathSuper);
            CutMap();
        }
        private void CutMap()
        {
            cor = map.Split(cut);
            DrawMap();
        }
        private void DrawMap()
        {
            for (int i = 0; i < cor.Length; i++)
            {
                string temps = cor[i];
                corString = temps.Split(' ');
                corInt = Array.ConvertAll(corString, s => int.Parse(s));
                Printe printe = new Printe();
                printe.PrintMessage(corInt[0], corInt[1], " ", corInt[2], 0);
            }
        }
    }
}
