using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
    public class Menu {

        private string[] firstMenuArray = new string[] { "1 Logga in", "2 Skapa ny användare", "3 Logga inte in" };
        private string[] secondMenuPartOneArray = new string[] { "1 Böcker", "2 Datorspel", "3 Filmer" };
        private string[] thirdMenuPartTwoArray = new string[] { "K Kundvagn", "B Betala", "L Logga in/ut" };

        public Menu(bool isThisTheFirstMenu) {

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int a = 0; a < 30; a++) {

                Console.Write("#");

            }

            Console.WriteLine();

            int arrayLength = 0;

            if (isThisTheFirstMenu == true) {

                arrayLength = firstMenuArray.Length;

            } else {

                arrayLength = secondMenuPartOneArray.Length;

            }

            for (int i = 0; i < arrayLength; i++) {

                for (int d = 0; d < 30; d++) {

                    if (d == 0 || d == 29) {

                        Console.Write("#");

                    } else {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

                Console.Write("#   ");

                string arrayValueToBeWrittenOut = "";

                if (isThisTheFirstMenu == true) {

                    arrayValueToBeWrittenOut = firstMenuArray[i];

                } else {

                    arrayValueToBeWrittenOut = secondMenuPartOneArray[i];

                }

                Console.Write(arrayValueToBeWrittenOut);

                for (int e = 0; e < (25 - arrayValueToBeWrittenOut.Length); e++) {

                    Console.Write(" ");

                }

                Console.Write("#");

                Console.WriteLine();

            }

            for (int b = 0; b < 30; b++) {

                if (b == 0 || b == 29) {

                    Console.Write("#");

                } else {

                    Console.Write(" ");

                }

            }

            Console.WriteLine();

            for (int c = 0; c < 30; c++) {

                Console.Write("#");

            }

            Console.WriteLine();

            if (isThisTheFirstMenu == false) {

                for (int h = 0; h < 30; h++) {

                    if (h == 0 || h == 29) {

                        Console.Write("#");

                    } else {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

                for (int j = 0; j < thirdMenuPartTwoArray.Length; j++) {

                    Console.Write("#   ");

                    string arrayValueToBeWrittenOut = thirdMenuPartTwoArray[j];

                    Console.Write(arrayValueToBeWrittenOut);

                    for (int e = 0; e < (25 - arrayValueToBeWrittenOut.Length); e++) {

                        Console.Write(" ");

                    }

                    Console.Write("#\n");

                }

                for (int g = 0; g < 30; g++) {

                    if (g == 0 || g == 29) {

                        Console.Write("#");

                    } else {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

                for (int f = 0; f < 30; f++) {

                    Console.Write("#");

                }

            }

            Console.WriteLine();

            Console.ResetColor();

        }
    }
}
