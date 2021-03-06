using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using ASM2_SE140281_Library;

namespace ASM2_SE140281
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageBook Man = new ManageBook();
            string ID;
            int input = 0;
            do
            {

                Clear();
                WriteLine("***Welcome to Book Library System***");
                WriteLine("1.Add new book");
                WriteLine("2.Update book");
                WriteLine("3.Delete Book");
                WriteLine("4.Show all Book");
                WriteLine("5.Quit");
                Write("Choose: ");
                input = Validation.CheckInput();

                switch (input)
                {
                    //Add New book
                    case 1:
                        WriteLine("***Add new book***");
                        Man.AddNewBook();
                        ReadLine();
                        break;
                    //Update Book
                    case 2:
                        WriteLine("***Update book by ID***");
                        Write("Enter ID: ");
                        ID = Console.ReadLine();
                        Man.UpdateBook(ID);
                        ReadLine();
                        break;
                    //Delete Book
                    case 3:
                        WriteLine("***Delete Book by ID***");
                        Write("Enter ID: ");
                        ID = Console.ReadLine();
                        Man.DeleteBook(ID);
                        ReadLine();
                        break;
                    //Show all Book
                    case 4:
                        WriteLine("***Show all Book***");
                        Man.ShowAll();
                        ReadLine();
                        break;
                    case 5:
                        WriteLine("Goodbye");
                        ReadLine();
                        break;

                    default:
                        WriteLine("Invalid Choice!");
                        ReadLine();
                        break;
                }
            } while (input != 5);
        }
    }
}
