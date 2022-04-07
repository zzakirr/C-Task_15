using System;
using System.Collections;
namespace Practice_15._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book1 = new Book();
            book1.Name = "name1";
            book1.AuthorName = "zakir1";
            book1.PageCount = 160;
            Book book2 = new Book();
            book2.Name = "name2";
            book2.AuthorName = "zakir2";
            book2.PageCount = 200;

            
            library.Books.Add(book1);
            library.Books.Add(book2);
            foreach (var item in library.Books)
            {
                Console.WriteLine($"Name:{item.Name}-AutorName:{item.AuthorName}-PageCount:{item.PageCount}");
            }
            Console.WriteLine("-----------FindByName-------------");
            foreach (var item in library.FindAllBooksByName("name1"))
            {
                Console.WriteLine($"Name:{item.Name}-AutorName:{item.AuthorName}-PageCount:{item.PageCount}");
            }
            Console.WriteLine("--------RemoveByNmae----------------");
            foreach (var item in library.RemoveAllBooksByName("name2"))
            {
                Console.WriteLine($"Name:{item.Name}-AutorName:{item.AuthorName}-PageCount:{item.PageCount}");
            }
            Console.WriteLine("---------------------------------------------");
            foreach (var item in library.SearchBooks("zakir1"))
            {
                Console.WriteLine($"Name:{item.Name}-AutorName:{item.AuthorName}-PageCount:{item.PageCount}");
            }
        }
    }
}
