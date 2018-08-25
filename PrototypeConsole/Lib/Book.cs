using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace PrototypeConsole.Lib
{
    [Serializable]
    class Book
    {
        public string Name { get; set; }
        public DateTime PublisDate { get; set; }
        public List<Page> Content { get; set; }


        /// <summary>
        /// Initial constructor with writing the book!
        /// </summary>
        /// <param name="name"></param>
        /// <param name="publishDate"></param>
        public Book(string name, DateTime publishDate)
        {
            Name = name; PublisDate = publishDate; Content = WritingTheBook();
        }

        /// <summary>
        /// Dummy writing process for the sake of the example
        /// </summary>
        /// <returns>The typesetted book.</returns>
        List<Page> WritingTheBook()
        {
            Content = new List<Page>();
            for (int i = 0; i < 10; i++)
            {
                Content.Add(new Page { PageNum = i + 1, SomeText ="Lorem Ipsum" });
            }
            Console.WriteLine("Wow! It takes too much time to write a book!");
            Thread.Sleep(3000); // Just pretending writing a book takes some time, in "reality" it is instant.
            return Content;

        }

        /// <summary>
        /// Demonstrating the changes in clones.
        /// </summary>
        public void MissWriteSomething()
        {
            Content.ElementAt(new Random().Next(1, 10)).SomeText = "Mistakes were made.";
        }

        /// <summary>
        /// Cloning : Deep COPY - with serializing.
        /// </summary>
        /// <returns></returns>
        public Book Clone()
        {
            // return new Book(Name, PublisDate, Content); -> this way still looks like a shallow copy.

            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, SeekOrigin.Begin);
            Book b = (Book)bf.Deserialize(ms);
            ms.Close();
            return b;
        }

        public Book ShallowClone()
        {
            return (Book)MemberwiseClone();
        }

        public void ShowMeWhatUGot()
        {
            Console.WriteLine(string.Format("Name of the Book : {0} | HashCodeOfObj = {1}", Name, GetHashCode().ToString()));
            Console.WriteLine("Pages Hash Code : "+ Content.GetHashCode().ToString());  
            foreach (var page in Content)
            {
                Console.WriteLine("Page {0}'s SomeText is {1}", page.PageNum, page.SomeText);
            }
        }
    }
}
