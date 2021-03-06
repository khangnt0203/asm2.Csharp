using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ASM2_SE140281_Library
{
    
        public class Book
        {
            private string ID;
            private string Name;
            private string Publisher;
            private int Price;

            //constructor
            public Book()
            {
            }

            public Book(string ID, string Name, string Publisher, int Price)
            {
                this.ID = ID;
                this.Name = Name;
                this.Publisher = Publisher;
                this.Price = Price;
            }

            //getters, setters
            public string BookID
            {
                get => ID;
                set => ID = value;
            }

            public string BookName
            {
                get => Name;
                set => Name = value;
            }

            public string BookPublisher
            {
                get => Publisher;
                set => Publisher = value;
            }

            public int BookPrice
            {
                get => Price;
                set => Price = value;
            }

            //Input
            public Book Input()
            {
                Write("Enter ID: ");
                ID = Validation.CheckEmpty();
                Write("Enter Name: ");
                Name = Validation.CheckEmpty();
                Write("Enter Publisher: ");
                Publisher = Validation.CheckEmpty();
                Write("Enter Price: ");
                Price = Validation.CheckNumber();
                Book Book = new Book(ID, Name, Publisher, Price);
                return Book;
            }

            //Output
            public string Output()
            {
                return "ID : " + ID + ", Name : " + Name
                    + ", Publisher : " + Publisher + ", Price : " + Price;
            }
        }
    }

