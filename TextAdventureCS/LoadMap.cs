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
        private string pathBank;
        private string pathStation;
        private string pathBakery;
        private string pathHome;
        private string pathFabric;
        private string pathHospital;
        private string pathJob;
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
            this.pathBank = @"maps\bank.txt";
            this.pathStation = @"maps\station.txt";
            this.pathBakery = @"maps\Bakery.txt";
            this.pathHome = @"maps\Home.txt";
            this.pathFabric = @"maps\Fabric.txt";
            this.pathHospital = @"maps\Hospital.txt";
            this.pathJob = @"maps\Job.txt";

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
        public void LoadBank()
        {
            map = File.ReadAllText(pathBank);
            CutMap();
        }
        public void LoadStation()
        {
            map = File.ReadAllText(pathStation);
            CutMap();
        }
        public void LoadBakery()
        {
            map = File.ReadAllText(pathBakery);
            CutMap();
        }
        public void LoadFabric()
        {
            map = File.ReadAllText(pathFabric);
            CutMap();
        }
        public void LoadHome()
        {
            map = File.ReadAllText(pathHome);
            CutMap();
        }
        public void LoadHospital()
        {
            map = File.ReadAllText(pathHospital);
            CutMap();
        }
        public void LoadJob()
        {
            map = File.ReadAllText(pathJob);
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
