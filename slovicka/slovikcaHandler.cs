using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace slovicka
{
    public static class handleSlovicka
    {
        public static List<String> slovickaCZ = new List<String>();
        public static List<String> slovickaEN = new List<String>();

        public static List<int> seed = new List<int>();

        public static List<Vector2> score = new List<Vector2>();

        public static List<int> historyData = new List<int>();

        public static int dobre = 0;
        public static int spatne = 0;

        public static string filePath;

        public static int number;

        public static bool cesky = true;

        public static void Reset()
        {
            slovickaCZ.Clear();
            slovickaEN.Clear();
            seed.Clear();
            score.Clear();
            dobre = 0;
            spatne = 0;
        }

        public static void chechIfFileExists()
        {
            if (!File.Exists(filePath + @"\slovicka.txt"))
            {
                File.CreateText(filePath + @"\slovicka.txt");
            }

            if (!File.Exists(filePath + @"\historie.txt"))
            {
                File.CreateText(filePath + @"\historie.txt");
            }
        }

        public static void WriteToHistory(float perc)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(filePath + @"\historie.txt", true))
            {
                file.WriteLine(DateTime.Now.ToString("dd.MM.yyyy") + ";" + perc.ToString());
            }
        }

        public static void getHistoryData()
        {
            string[] lines = File.ReadAllLines(filePath + @"\historie.txt");

            foreach (string line in lines)
            {
                int a = Convert.ToInt32(line.Split(';')[1]);
                historyData.Add(a);
            }
        }

        public static void loadSlovicka()
        {
            string[] lines = File.ReadAllLines(filePath + @"\slovicka.txt");

            foreach (string line in lines)
            {
                slovickaEN.Add(line.Split(';')[0]);
                slovickaCZ.Add(line.Split(';')[1]);
            }
        }

        public static void createSeed()
        {
            int count = handleSlovicka.number;
            for (int i = 0; i < count; i++)
            {
                System.Random rnd = new System.Random();
                int nr = rnd.Next(0, handleSlovicka.slovickaCZ.Count);
                if (seed.Contains(nr))
                {
                    i--;
                    continue;
                }
                seed.Add(nr);
            }
        }
    }
}