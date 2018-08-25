using PrototypeConsole.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> publishedCopies = new List<Book>(4);
            Book initalBook = new Book("First Book", DateTime.Now);
            initalBook.ShowMeWhatUGot();
            for (int i = 0; i < 3; i++)
            {
                publishedCopies.Add(initalBook.Clone());
            }

            publishedCopies[2].MissWriteSomething();

            foreach (var book in publishedCopies)
            {
                book.ShowMeWhatUGot();
                Console.WriteLine("----------------------------------------------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
