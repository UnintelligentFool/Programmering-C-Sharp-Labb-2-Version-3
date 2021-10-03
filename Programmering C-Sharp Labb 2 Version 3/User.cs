using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
        class User : NewItem {

        private string name;

        public string Name {
            get { return name; }
            set { name = value; }
        }


        private string lastName;

        public string Lastname {
            get { return lastName; }
            set { lastName = value; }
        }


        private string userName;

        public string Username {
            get { return userName; }
            set { userName = value; }
        }


        private string membershipLevel;

        public string MembershipLevel {
            get { return membershipLevel; }
            set { membershipLevel = value; }
        }


        private string password;

        public string Password {
            get { return password; }
            private set { password = value; }
        }

        private static List<string[]> newCart;

        public List<string[]> NewCart {
            get { return NewCart1; }
            set { NewCart1 = value; }
        }

        public static List<string[]> NewCart1 { get => newCart; set => newCart = value; }

        protected List<string[]> anotherCart = new List<string[]>() {  };

        public User(string username/*, string password*/) {

            //CheckCart();

        }

        //List<string[]> iHateCarts = new List<string[]>(UsersShoppingCart);//Die cart die

        public User(string username, string password, string name, string lastname, string membershipLevel) {
            Name = name;
            Lastname = lastname;
            Username = username;
            MembershipLevel = membershipLevel;
            Password = password;
            
            //UsersShoppingCart = shoppingcart;
            
//            for (int i = 0; i < shoppingcart.Count; ) {
//
//                UsersShoppingCart.Add(shoppingcart[i]);
//
//                shoppingcart.RemoveAt(i);
//
//            }

            /*for (int i = 0; i < shoppingcart.Count; i++) {

                UsersShoppingCart.Add(shoppingcart[i]);

            }*/

            //UsersShoppingCart = new List<string[]>(Program.shoppingCartList);

            //List<string[]> usersCart = new List<string[]>(Program.shoppingCartList);//Fungerade..

            //UsersShoppingCart.AddRange(Program.shoppingCartList);
            //UsersShoppingCart = shoppingcart;
            //UsersShoppingCart.AddRange(Program.shoppingCartList);

            //List<string[]> iHateCarts = new List<string[]> (UsersShoppingCart);
            
            //iHateCarts.GetRange(0, UsersShoppingCart.Count;

            string[] newUser = new string[] { username, password, name, lastname, membershipLevel };

            Program.listOfUsers.Add(newUser);

        }


        public User(string[] itemArray) {



            NewItem newBook = new NewItem();
            newBook.Title = itemArray[0];
            newBook.Author = itemArray[1];
            newBook.ItemNumber = itemArray[2];
            newBook.Price = itemArray[3];

            Console.WriteLine("Work! Work! Work!");

            /*NewItem itemma = new NewItem();
            Console.WriteLine("Title: " + itemma.Title);
            Console.WriteLine("Author: " + itemma.Author);
            Console.WriteLine("ItemNumber: " + itemma.ItemNumber);
            Console.WriteLine("Price: " + itemma.Price);*/

            Console.WriteLine("Title: " + newBook.Title);
            Console.WriteLine("Author: " + newBook.Author);
            Console.WriteLine("ItemNumber: " + newBook.ItemNumber);
            Console.WriteLine("Price: " + newBook.Price);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Tillagd i kundvagnen: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(newBook.Title.ToString() + "\n");
            Console.ResetColor();

            string[] itemValues = new string[4] { newBook.Title, newBook.Author, newBook.ItemNumber, newBook.Price };
            
            anotherCart.Add(itemValues);//ArrayOfItems
            Console.WriteLine("Items being sent received by User class!");
            //Console.WriteLine("User is getting a: " + NewCart[(NewCart.Count - 1)]);

            Console.WriteLine("Noooooo!");

            //shoppingCartList.Add(Books_Page.listOfBooks[i]);
            //List<string[]> listOfBooks = new List<string[]>() { Book1, Book2, Book3 };
        }

        //public static void LetUsCheckTheCart() {

        //    CheckCart(anotherCart);

        //}

        //public void CheckCart(anotherCart) {

        //    for (int i = 0; i < anotherCart.Count; i++) {

        //        Console.WriteLine(anotherCart[i][0]);

        //    }

        //}
    }
}


/*
 
 Två sätt att komma åt användaren, två konstruktorer? En där användare skapas och en som körs vid inloggning? Är det vad jag håller på med? O.o
 
*/


/*
 
 string name;

 string lastName;

 string vipMember; //4 värden, om jag implementerar det, "No"/"Bronze"/"Silver"/"Gold"

 string password;
 
 */
