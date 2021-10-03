using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
    class Merchandise {
        public Merchandise(string[] headerAndCategories, string merchandise_Page, List<string[]> merchandiseList) {

            string kindOfMerchandise = merchandise_Page;

            List<string[]> listOfMerchandise = merchandiseList;

            string header = headerAndCategories[0];
            string categoryOne = headerAndCategories[1];
            string categoryTwo = headerAndCategories[2];
            string categoryThree = headerAndCategories[3];
            string categoryFour = headerAndCategories[4];

            Console.WriteLine("\n     För att handla, skriv varunummret på varan du vill köpa.");

            Console.WriteLine("\n");

            for (int a = 0; a < 107; a++) {

                if (a < 5) {

                    Console.Write(" ");

                } else {

                    if (a % 2 == 0) {

                        Console.Write(">");

                    } else {

                        Console.Write("<");

                    }

                }

            }

            Console.WriteLine();

            for (int b = 0; b < 107; b++) {

                if (b < 5) {

                    Console.Write(" ");

                } else if (b == 5 || b == 105) {

                    Console.Write("<");

                } else if (b == 6 || b == 106) {

                    Console.Write(">");

                } else {

                    int adjustUnevenNumber = 0;

                    if (header.Length % 2 == 0) {

                        adjustUnevenNumber = 0;

                    } else {

                        adjustUnevenNumber = 1;

                    }

                    if (b < (56 - header.Length / 2)) {

                        Console.Write(" ");

                    } else if (b == (56 - header.Length / 2)) {

                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.Write(header);

                        Console.ResetColor();

                    } else if (b > 52 + header.Length - adjustUnevenNumber) {

                        Console.Write(" ");

                    }

                }

            }

            Console.WriteLine();

            for (int c = 0; c < 107; c++) {

                if (c < 5) {

                    Console.Write(" ");

                } else {

                    if (c % 2 == 0) {

                        Console.Write(">");

                    } else {

                        Console.Write("<");

                    }

                }

            }

            Console.WriteLine();

            for (int d = 0; d < 107; d++) {

                if (d < 5) {

                    Console.Write(" ");

                } else if (d == 5 || d == 93) {

                    Console.Write("<");

                } else if (d == 6 || d == 94) {

                    Console.Write(">");

                } else {

                    int adjustUnevenNumber = 0;

                    if (categoryOne.Length % 2 == 0) {

                        adjustUnevenNumber = 0;

                    } else {

                        adjustUnevenNumber = 1;

                    }

                    if (d == (27 - categoryOne.Length / 2)) {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write(categoryOne);

                        Console.ResetColor();

                    }

                    if (d == 34 - adjustUnevenNumber) {

                        Console.Write("<>");

                    }

                    if (categoryTwo.Length % 2 == 0) {

                        adjustUnevenNumber = 0;

                    } else {

                        adjustUnevenNumber = 1;

                    }

                    if (d < ((54 - categoryOne.Length) - categoryTwo.Length / 2)) {

                        Console.Write(" ");

                    } else if (d == 54 - categoryTwo.Length / 2) {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write(categoryTwo);

                        Console.ResetColor();

                    }

                    int secondAdjustUnevenNumber = 0;

                    if (categoryThree.Length % 2 == 0) {

                        secondAdjustUnevenNumber = 0;

                    } else {

                        secondAdjustUnevenNumber = 1;

                    }

                    if (d == 70 + (categoryTwo.Length + adjustUnevenNumber) / 2) {

                        Console.Write("<>");

                    }

                    int thirdAdjustUnevenNumber = 0;

                    if (categoryOne.Length % 2 == 0) {

                        thirdAdjustUnevenNumber = 0;

                    } else {

                        thirdAdjustUnevenNumber = 1;

                    }

                    if (d == 64 + categoryOne.Length + categoryTwo.Length + categoryThree.Length / 2 + adjustUnevenNumber - secondAdjustUnevenNumber - thirdAdjustUnevenNumber) {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write(categoryThree);

                        Console.ResetColor();

                    } else if (d > 55 + categoryTwo.Length + adjustUnevenNumber - secondAdjustUnevenNumber) {

                        Console.Write(" ");

                    }

                    if (d == 80 + (categoryTwo.Length + adjustUnevenNumber) / 2) {

                        Console.Write("<>");

                    }

                    if (d == 86 + categoryThree.Length / 2) {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write(categoryFour);

                        Console.ResetColor();

                    }

                }

            }

            Console.WriteLine();

            for (int e = 0; e < 107; e++) {

                if (e < 5) {

                    Console.Write(" ");

                } else {

                    if (e % 2 == 0) {

                        Console.Write(">");

                    } else {

                        Console.Write("<");

                    }

                }

            }

            Console.WriteLine("\n\n");

            for (int f = 0; f < 107; f++) {

                if (f < 5) {

                    Console.Write(" ");

                } else if (f == 5) {

                    Console.Write("<");

                } else if (f == 106) {

                    Console.Write(">");

                } else {

                    Console.Write("-");

                }

            }

            Console.WriteLine();

            for (int i = 0; i < listOfMerchandise.Count; i++) {

                for (int g = 0; g < 107; g++) {

                    if (g < 5) {

                        Console.Write(" ");

                    } else if (g == 5) {

                        Console.Write("<");

                    } else if (g == 6) {

                        Console.Write("-");

                    } else if (g > 6 && g < 10) {

                        Console.Write(" ");

                    }

                }

                if (i % 2 == 0) {

                    Console.ForegroundColor = ConsoleColor.Blue;

                } else {

                    Console.ForegroundColor = ConsoleColor.Red;

                }

                Console.Write(listOfMerchandise[i][0]);
                
                for (int j = 0; j < 46 - (listOfMerchandise[i][0].Length) - (listOfMerchandise[i][1].Length / 2); j++) {

                    Console.Write(" ");

                }

                Console.Write(listOfMerchandise[i][1]);

                int fourthAdjustmentNumber = 0;

                if (listOfMerchandise[i][1].Length % 2 == 0) {

                    fourthAdjustmentNumber = 0;

                } else {

                    fourthAdjustmentNumber = 1;

                }

                for (int k = 0; k < 21 - fourthAdjustmentNumber - (listOfMerchandise[i][1].Length / 2); k++) {

                    Console.Write(" ");

                }

                Console.Write(listOfMerchandise[i][2]);

                int sixthAdjustmentNumber = 0;

                if (listOfMerchandise[i][2].Length % 2 == 0) {

                    sixthAdjustmentNumber = 0;

                } else {

                    sixthAdjustmentNumber = 1;

                }


                for (int k = 0; k < 16 - sixthAdjustmentNumber - (listOfMerchandise[i][2].Length / 2); k++) {

                    Console.Write(" ");

                }

                Console.Write(listOfMerchandise[i][3]);

                Console.ResetColor();

                for (int h = 0; h < 10; h++) {

                    if (h == 8) {

                        Console.Write("-");

                    } else if (h == 9) {

                        Console.Write(">");

                    } else {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

            }

            for (int j = 0; j < 107; j++) {

                if (j < 5) {

                    Console.Write(" ");

                } else if (j == 5) {

                    Console.Write("<");

                } else if (j == 106) {

                    Console.Write(">");

                } else {

                    Console.Write("-");

                }

            }

            Console.WriteLine();

        }
    }
}
