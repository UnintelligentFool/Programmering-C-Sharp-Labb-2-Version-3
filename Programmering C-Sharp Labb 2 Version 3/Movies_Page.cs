﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
    class Movies_Page {


        //Film Titel, Filmbolag, Pris, Varunummer
        public static string[] Movie1 = new string[] { "Black Book", "Egmont", "129", "201" };
        public static string[] Movie2 = new string[] { "Star Wars III - Mörkrets Hämnd", "Lucasfilm Ltd.", "119", "202" };
        public static string[] Movie3 = new string[] { "Appleseed", "Digital Frontier", "99", "203" };

        public static List<string[]> listOfMovies = new List<string[]>() { Movie1, Movie2, Movie3 };

        public static string[] headlineAndCategories = new string[] { "Filmer", "Film", "Filmbolag", "Pris", "Varunummer" };

        public int itemnumber = 0;

        public Movies_Page() {


            Merchandise movies_Page = new Merchandise(headlineAndCategories, "Movies_Page", listOfMovies);

            WhatMovieToCreate(itemnumber);

        }

        public static void WhatMovieToCreate(int itemnumber) {

            if (itemnumber == 101) {

                MakeAMovie(Movie1);

            }

            if (itemnumber == 102) {

                MakeAMovie(Movie2);

            }

            if (itemnumber == 103) {

                MakeAMovie(Movie3);

            }

        }

        public static void MakeAMovie(string[] MovieValuesArray) {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Tillagd i kundvagnen: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(MovieValuesArray[0] + "\n");
            Console.ResetColor();

        }

    }
}
