using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Practice_15._3
{
    internal class Library
    {
        List<Book> _books = new List<Book>();
        public List<Book> Books { get { return _books; } }
        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (Book item in Books)
            {
                if (item.Name.Contains(name))
                {
                    NewBooks.Add(item);
                }
            }
            return NewBooks;
        }
        public List<Book> RemoveAllBooksByName(string name)
        {
            List<Book> NewBooks = new List<Book>();
            foreach (Book item in Books)
            {
                if (item.Name != name)
                {
                   NewBooks.Add(item);
                }
            }
            _books = NewBooks;
            return NewBooks;
        }
        public List<Book> SearchBooks(string str)
        {
            List<Book> MyList = new List<Book>();

            foreach (var item in Books)
            {
                if (item.Name == str || item.AuthorName == str || Convert.ToString(item.PageCount) == str)
                {
                    MyList.Add(item);
                }
            }
            return MyList;
        }

    }
}
