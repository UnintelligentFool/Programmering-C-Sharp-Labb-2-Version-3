using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_C_Sharp_Labb_2_Version_3 {
    public class NewItem {

        private string title;

        public string Title {
            get { return title; }
            set { title = value; }
        }

        private string author;

        public string Author {
            get { return author; }
            set { author = value; }
        }

        private string itemNumber;

        public string ItemNumber {
            get { return itemNumber; }
            set { itemNumber = value; }
        }

        private string price;

        public string Price {
            get { return price; }
            set { price = value; }
        }

        private string[] arrayOfItems;

        public string[] ArrayOfItems {
            get { return arrayOfItems; }
            set { arrayOfItems = value; }
        }


        public NewItem(string title, string author, string itemnumber, string price) {

            Title = title;
            Author = author;
            ItemNumber = itemnumber;
            Price = price;
            //ArrayOfItems = new string[4] { Title, Author, ItemNumber, Price };

        }

        public NewItem() {

            //SendingItem(Title, Author, ItemNumber, Price);

            ArrayOfItems = new string[4] { Title, Author, ItemNumber, Price };

        }

    }

}

/*
  
    Istället för att lägga bok med nummer i en lista, lägga instansnamn i en lista? Skapa instans när nummer 
    skrivs in och sedan lägga dess namn i en lista i kund?

 */