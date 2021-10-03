
using System;
using System.Collections.Generic;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
    class Program {

        public static string[] knatte = new string[] { "Knatte", "123", "Knatte", "Anka", "Gold" };
        public static string[] fnatte = new string[] { "Fnatte", "321", "Fnatte", "Anka", "Silver" };
        public static string[] tjatte = new string[] { "Tjatte", "213", "Tjatte", "Anka", "Bronze" };

        public static List<string[]> listOfUsers = new List<string[]>() { knatte, fnatte, tjatte };

        private static bool isSomeoneOnline = false;
        public static bool IsSomeoneOnline {
            get { return isSomeoneOnline; }
            set { isSomeoneOnline = value; }
        }

        private static string userOnline = "Quentin";
        public static string UserOnline {
            get { return userOnline; }
            set { userOnline = value; }
        }


        static void Main(string[] args) {

            GreetingUser();

        }

        public static void GreetingUser() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu firstMenu = new Menu(true);

            Greeting_User greeting_User = new Greeting_User();

            Keystrokes(true, listOfUsers);

        }

        public static void LoginAndLogout() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Login_And_Logout login_And_Logout = new Login_And_Logout(listOfUsers, IsSomeoneOnline, UserOnline);

            Keystrokes(true, listOfUsers);

        }

        public static void CreateNewUser() {

            Create_New_User create_New_User = new Create_New_User();

            User newUser = new User(Create_New_User.newUsersUsername, Create_New_User.newUsersPassword, Create_New_User.newUsersFirstName, Create_New_User.newUsersLastName, Create_New_User.newUsersMembershipLevel);

            MainMenu();

            Keystrokes(false, listOfUsers);

        }

        public static void MainMenu() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            Keystrokes(false, listOfUsers);

        }

        public static void Books() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            Books_Page books_Page = new Books_Page();

            Keystrokes(false, listOfUsers);

        }

        public static void Games() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            Games_Page games_Page = new Games_Page();

            Keystrokes(false, listOfUsers);

        }

        public static void Movies() {

            ShowOnlineCustomer showOnlineCustomer = new ShowOnlineCustomer(IsSomeoneOnline, UserOnline);

            Menu mainMenu = new Menu(false);

            Movies_Page movies_Page = new Movies_Page();

            Keystrokes(false, listOfUsers);

        }

        public static string[] AddToCart(string[] itemArray) {

            string[] itemValuesArray = itemArray;


            NewItem myNewItem = new NewItem();
            myNewItem.Title = itemArray[0];
            myNewItem.Author = itemArray[1];
            myNewItem.ItemNumber = itemArray[2];
            myNewItem.Price = itemArray[3];

            Console.WriteLine("Title: " + myNewItem.Title);
            Console.WriteLine("Author: " + myNewItem.Author);
            Console.WriteLine("ItemNumber: " + myNewItem.ItemNumber);
            Console.WriteLine("Price: " + myNewItem.Price);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Tillagd i kundvagnen: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(myNewItem.Title.ToString() + "\n");
            Console.ResetColor();

            string[] itemValues = new string[4] { myNewItem.Title, myNewItem.Author, myNewItem.ItemNumber, myNewItem.Price };

            //foreach (string user in UserOnline) {

            //    if() { 

            //        User.NewCart1.Add(itemArray);

            //    }
            //}

            User.NewCart1.Add(itemArray);

            return (itemArray);

        }

        public static void Keystrokes(bool firstmenu, List<string[]> listOfUsers) {

            string usersInput = Console.ReadLine().ToUpper();

            bool firstMenu = firstmenu;

            if (usersInput == "1" || usersInput == "2" || usersInput == "3" || usersInput == "4" || usersInput == "5" || usersInput == "K" || usersInput == "B" || usersInput == "L") {

                if (usersInput == "1" && firstMenu == true) {

                    Console.Clear();

                    LoginAndLogout();

                } else if (usersInput == "1" && firstMenu == false) {

                    Console.Clear();

                    Books();

                } else if (usersInput == "2" && firstMenu == true) {

                    Console.Clear();

                    CreateNewUser();

                } else if (usersInput == "2" && firstMenu == false) {

                    Console.Clear();

                    Games();

                } else if (usersInput == "3" && firstMenu == true) {

                    Console.Clear();

                    Menu showMenu = new Menu(false);

                    Keystrokes(false, listOfUsers);

                } else if (usersInput == "3" && firstMenu == false) {

                    Console.Clear();

                    Movies();

                } else if (usersInput == "4" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "4" && firstMenu == false) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "5" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "5" && firstMenu == false) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "K" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "K" && firstMenu == false) {

                    Console.Clear();

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "B" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "B" && firstMenu == false) {

                    Console.Clear();

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "L" && firstMenu == true) {

                    Keystrokes(firstMenu, listOfUsers);

                } else if (usersInput == "L" && firstMenu == false) {

                    Console.Clear();

                    LoginAndLogout();

                }

            } else if (usersInput == "101") {

                Books_Page.WhatBookToCreate(101);

            } else if (usersInput == "102") {

                Books_Page.WhatBookToCreate(102);

            } else if (usersInput == "103") {

                Books_Page.WhatBookToCreate(103);

            } else if (usersInput == "104") {

                Books_Page.WhatBookToCreate(104);

            } else if (usersInput == "105") {

                Books_Page.WhatBookToCreate(105);

            } else if (usersInput == "106") {

                Books_Page.WhatBookToCreate(106);

            } else if (usersInput == "107") {

                Books_Page.WhatBookToCreate(107);

            } else {


                Keystrokes(firstMenu, listOfUsers);

            }

        }

    }
}
