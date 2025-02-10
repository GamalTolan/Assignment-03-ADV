using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_03_ADV.Book;

namespace Assignment_03_ADV
{
    public class LibraryEngine
    {
        public delegate string BookFunctionDelegate(Book B);

        public static void ProcessBooks(List<Book> bList, BookFunctionDelegate fPtr)
        {
            foreach (Book b in bList)
            {
                Console.WriteLine(fPtr(b));

            }
        }
    }
}
