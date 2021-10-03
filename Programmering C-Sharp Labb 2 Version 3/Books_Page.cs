using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
    class Books_Page {

        //Bok Titel, Författare, Pris, Varunummer
        public static string[] Book1 = new string[] { "Ödets Fullbordan", "David Eddings", "99", "101" };
        public static string[] Book2 = new string[] { "Elantris", "Brandon Sanderson", "85", "102" };
        public static string[] Book3 = new string[] { "Sista Riket", "Brandon Sanderson", "212", "103" };
        public static string[] Book4 = new string[] { "Svarta Tornet", "Robert Jordan", "169", "104" };
        public static string[] Book5 = new string[] { "The Saga of Tanya the Evil", "Carlo Zen", "179", "105" };
        public static string[] Book6 = new string[] { "The Eye of the World", "Robert Jordan", "79", "106" };
        public static string[] Book7 = new string[] { "The Great Hunt", "Robert Jordan", "79", "107" };

        public static List<string[]> listOfBooks = new List<string[]>() { Book1, Book2, Book3, Book4, Book5, Book6, Book7 };

        public static string[] headlineAndCategories = new string[] { "Böcker", "Titel", "Författare", "Pris", "Varunummer" };

        private static int itemnumber = 0;

        public static int Itemnumber {
            get { return itemnumber; }
            set { itemnumber = value; }
        }


        public Books_Page() {

            Merchandise books_Page = new Merchandise(headlineAndCategories, "Books_Page", listOfBooks);

            WhatBookToCreate(itemnumber);

        }

        public static void WhatBookToCreate(int itemnumber) {

            if (itemnumber == 101) {

                MakeABook(Book1);

            }

            if (itemnumber == 102) {

                MakeABook(Book2);

            }

            if (itemnumber == 103) {

                MakeABook(Book3);

            }

            if (itemnumber == 104) {

                MakeABook(Book4);

            }

            if (itemnumber == 105) {

                MakeABook(Book5);

            }

            if (itemnumber == 106) {

                MakeABook(Book6);

            }

            if (itemnumber == 107) {

                MakeABook(Book7);

            }

        }

        public static void MakeABook(string[] BookValuesArray) {

            Itemnumber = 0;

            Console.Clear();

            Program.AddToCart(BookValuesArray);

        }

    }
}
