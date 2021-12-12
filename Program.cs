using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ_To_Object_using_Fluent_Syntax
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sort of Data with order .

            Book[] Books = 
            {
                new Book() { Id = 4, Title = "C# in Depth", Author = "Mark James" },
                new Book() { Id = 2, Title = "Javascript in 0", Author = "john wick" },
                new Book() { Id = 1, Title = "Java", Author = "Xman 12-0a" }
            };

            // In Query Syntax Sorting by order from Smallest Id to the Largest one .

            var List = from item
                       in Books
                       orderby item.Id
                       select item;

            foreach (var item in List)
                Console.WriteLine("Id = {0}, Title = {1}, Author = {2} ", item.Id, item.Title, item.Author);
        }
    }
}
