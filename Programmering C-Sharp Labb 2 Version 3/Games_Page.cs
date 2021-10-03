using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
    class Games_Page {

        //Spel Titel, Spelstudio, Pris, Varunummer
        public static string[] Game1 = new string[] { "Star Wars: Knights of the Old Republic", "BioWare Corp.", "299", "301" };
        public static string[] Game2 = new string[] { "Mass Effect", "BioWare", "179", "302" };
        public static string[] Game3 = new string[] { "Warlords Battlecry II", "SSG and Ubisoft", "189", "303" };
        public static string[] Game4 = new string[] { "Neverwinter Nights", "BioWare Corp.", "349", "304" };

        public static List<string[]> listOfGames = new List<string[]>() { Game1, Game2, Game3, Game4 };

        public static string[] headlineAndCategories = new string[] { "Datorspel", "Spel", "Spelstudio", "Pris", "Varunummer" };

        public int itemnumber = 0;

        public Games_Page() {

            Merchandise games_Page = new Merchandise(headlineAndCategories, "Games_Page", listOfGames);

            WhatGameToCreate(itemnumber);

        }

        public static void WhatGameToCreate(int itemnumber) {

            if (itemnumber == 101) {

                MakeAGame(Game1);

            }

            if (itemnumber == 102) {

                MakeAGame(Game2);

            }

            if (itemnumber == 103) {

                MakeAGame(Game3);

            }

            if (itemnumber == 104) {

                MakeAGame(Game4);

            }

        }

        public static void MakeAGame(string[] GameValuesArray) {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Tillagd i kundvagnen: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(GameValuesArray[0] + "\n");
            Console.ResetColor();

        }

    }
}
