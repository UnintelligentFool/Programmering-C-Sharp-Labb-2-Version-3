using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
    class Create_New_User {

        public static string[] newUsersStrings = new string[5];

        public static string newUsersFirstName;
        public static string newUsersLastName;
        public static string newUsersUsername;
        public static string newUsersPassword;
        public static string newUsersMembershipLevel;

        
        public Create_New_User() {

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("             Så trevligt att ni vill bli våran kund.");
            Console.Write("             Vänligen bifoga följande information för att registreras hos oss.\n\n");
            Console.WriteLine("             Vilket är ditt förnamn?");

            newUsersFirstName = Console.ReadLine();
            newUsersStrings[0] += newUsersFirstName;

            Console.WriteLine("\n             Vilket är ditt efternamn?");

            newUsersLastName = Console.ReadLine();
            newUsersStrings[1] += newUsersLastName;

            Console.WriteLine("\n             Vilket användarnamn vill du använda? (Används vid inloggning.)");

            newUsersUsername = Console.ReadLine();
            newUsersStrings[2] += newUsersUsername;

            Console.WriteLine("\n             Vilket lösenord vill du använda?");

            newUsersPassword = Console.ReadLine();
            newUsersStrings[3] += newUsersPassword;

            DoYouWantPremiumServices();

        }

        public static void DoYouWantPremiumServices() {

            Console.WriteLine("\n             Vill du bli en av våra premium kunder?");
            Console.Write("             Svara något av följande: \"Nej\"/\"Bronze\"/\"Silver\"/\"Gold\"\n");

            newUsersMembershipLevel = Console.ReadLine().ToLower();

            if (newUsersMembershipLevel == "nej" || newUsersMembershipLevel == "bronze" || newUsersMembershipLevel == "silver" || newUsersMembershipLevel == "gold") {

                newUsersStrings[4] += newUsersMembershipLevel;

                ThankYouForCreatingAccount();

            } else {

                Console.WriteLine("Vänligen ange ett av de nämnda alternativen.\n");

                DoYouWantPremiumServices();

            }

        }

        public static void ThankYouForCreatingAccount() {

            Console.WriteLine("Tack för att du skapade ett konto hos oss!");

            Program.IsSomeoneOnline = true;

            Program.UserOnline = newUsersUsername;

            Console.ResetColor();

            Console.Clear();

        }
    }
}
