﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
    class Login_And_Logout {

        public static bool isSomeoneLoggedIn = false;

        public static string userLoggedIn = "";

        public Login_And_Logout(List<string[]> listOfUsers, bool isSomeoneOnline, string userOnline) {

            WhyAreYouHere(listOfUsers, isSomeoneOnline, userOnline);

        }

        public static void WhyAreYouHere(List<string[]> listOfUsers, bool isSomeoneOnline, string userOnline) {

            isSomeoneLoggedIn = isSomeoneOnline;
            userLoggedIn = userOnline;
            List<string[]> theListOfUsers = listOfUsers;
            
            if (isSomeoneLoggedIn == true) {

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("Vill du logga ut, skriv \"Ut\". Vill du logga in med ett annat konto, skriv \"In\". (\"x\" tar dig tillbaka.)");

                Console.ResetColor();

                string loggingOutOrIn = Console.ReadLine().ToLower();

                if (loggingOutOrIn == "in") {

                    LoggedInAllready(theListOfUsers, userLoggedIn);

                } else if (loggingOutOrIn == "ut") {

                    LoggingOut();

                } else if(loggingOutOrIn == "x" || loggingOutOrIn == "X") {

                    Console.Clear();
                    Program.MainMenu();
                
                } else {

                    WhyAreYouHere(listOfUsers, isSomeoneOnline, userOnline);

                }

            } else {

                TimeToLogIn(theListOfUsers, isSomeoneLoggedIn, userLoggedIn);
                
            }
            
        }

        public static void LoggedInAllready(List<string[]> theListOfUsers, string userLoggedIn) {

            Program.IsSomeoneOnline = false;
            Program.UserOnline = "";

            TimeToLogIn(theListOfUsers, isSomeoneLoggedIn, userLoggedIn);

        }

        public static void TimeToLogIn(List<string[]> theListOfUsers, bool isSomeoneLoggedIn, string userLoggedIn) {

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Ny kund? Tryck \"n\". \n(\"x\" tar dig tillbaka.)\n");
            Console.WriteLine("Ange ditt användarnamn:");

            Console.ResetColor();

            string enteredUsername = Console.ReadLine();

            if (enteredUsername == "x" || enteredUsername == "X") {

                Console.Clear();
                Program.MainMenu();

            }
            
            if (enteredUsername == "n" || enteredUsername == "N") {

                Console.Clear();
                Program.CreateNewUser();

            }

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Ange ditt lösenord:");

            Console.ResetColor();

            string enteredPassword = Console.ReadLine();

            if (enteredPassword == "x" || enteredPassword == "X") {

                Console.Clear();
                Program.MainMenu();

            }

            bool didUserEnterCorrectUsername = false;
            bool didUserEnterCorrectPassword = false;

            for (int i = 0; i < theListOfUsers.Count; i++) {

                if(enteredUsername == theListOfUsers[i][0]) {

                    if(enteredPassword == theListOfUsers[i][1]) {

                        didUserEnterCorrectUsername = true;
                        didUserEnterCorrectPassword = true;
                        
                        Program.IsSomeoneOnline = true;
                        Program.UserOnline = enteredUsername;

                        Console.Clear();

                        Program.MainMenu();
                    }

                } else {

                    didUserEnterCorrectUsername = false;

                }

            }

            if(didUserEnterCorrectUsername == true && didUserEnterCorrectPassword == true) {

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("Du bör nu vara inloggad.");

                Console.ResetColor();

            } else {

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("Ditt användarnamn eller lösenord verkar vara felaktigt. Vänligen försök igen.");

                Console.ResetColor();

                Console.WriteLine();

                WhyAreYouHere(theListOfUsers, isSomeoneLoggedIn, userLoggedIn);

            }         }

        public static void LoggingOut() {

            Program.IsSomeoneOnline = false;

            Program.UserOnline = "";

            Console.Clear();

            Program.MainMenu();

    }

    }
}

//Logga in --> Om redan inloggad, "LoggedInAllready" följt av "TimeToLogIn", annars bara "TimeToLogIn". Om loggar ut, logga ut.
//
// När man loggar ut --> Spara kundvagn hos användare och nollställ sedan den som används
// Om man har kundvagn och loggar in --> gör inloggad kunds kundvagn till den man hade alternativt fyll på den som inloggad hade?
// Om man loggar in utan att ha kundvagn --> inloggad kunds kundvagn = kundvagn som används
//
// Kontrollera och spara (tills utloggning) om användaren har olika VIP medlemsskap
