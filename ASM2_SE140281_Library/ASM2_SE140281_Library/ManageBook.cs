using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace ASM2_SE140281_Library
{
    public class ManageBook
    {
        private static List<Book> list = new List<Book>();

        public void AddNewBook()
        {
            Book NewBook = new Book();
            NewBook.Input();
            list.Add(NewBook);
        }

        private static Book FindBookByCode(string ID)
        {
            foreach (Book book in list)
            {
                if ((book.BookID).Equals(ID))
                {
                    return book;
                }
            }
            return null;
        }

        public void UpdateBook(string ID)
        {
            Book FoundBook = FindBookByCode(ID);
            if (FoundBook != null)
            {
                Book UpdateBook = new Book();
                UpdateBook.Input();
                list.Remove(FoundBook);
                list.Add(UpdateBook);
                Console.WriteLine("Updated!");
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }

        public void DeleteBook(string ID)
        {
            Book FoundBook = FindBookByCode(ID);
            if (FoundBook != null)
            {
                Console.WriteLine("This book will be removed (yes/no)");
                string Confirm = Validation.CheckConfirm();
                if (Confirm.Equals("yes"))
                {
                    list.Remove(FoundBook);
                    Console.WriteLine("Deleted !");
                }
                else if (Confirm.Equals("no"))
                {
                    Console.WriteLine("Cancel !");
                }

            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        public void ShowAll()
        {
            foreach (Book book in list)
            {
                Console.WriteLine(book.Output());
            }
        }
    }
}
