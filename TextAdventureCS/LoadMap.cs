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
        private string map;
        private int lengtCor;
        private char cut;
        List<string> cor = new List<string>();
        List<int> corInt = new List<int>();
        public LoadMap()
        {
            this.pathCity = @"C:\Users\School\Documents\school\leerjaar_1\Periode_3\projecten\Text-Adventure\TextAdventureCS\maps\map.txt";
            this.cut = ',';
        }
        public void LoadCity()
        {
            map = File.ReadAllText(pathCity);
        }
        public void CutMap()
        {
            cor.Add(map.Split(cut));
        }
        public void DrawMap()
        {
            string temp;
            lengtCor = cor.Last();
            for (int i = 0; i < lengtCor; i++)
            {
                temp = cor<i>;
                corInt.Add(temp.split);
            }
        }
    }
}
