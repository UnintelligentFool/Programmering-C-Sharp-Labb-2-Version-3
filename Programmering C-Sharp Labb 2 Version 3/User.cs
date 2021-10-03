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

        public User(string username) {

        }

        public User(string username, string password, string name, string lastname, string membershipLevel) {
            Name = name;
            Lastname = lastname;
            Username = username;
            MembershipLevel = membershipLevel;
            Password = password;
            
            string[] newUser = new string[] { username, password, name, lastname, membershipLevel };

            Program.listOfUsers.Add(newUser);

        }
        
        public static void ShowCart(string[] itemArray) { 

            for (int i = 0; i < NewCart1.Count; i++) {

                Console.WriteLine("Cart contains: " + NewCart1[i][0].ToString());

            }
        }
    }
}
