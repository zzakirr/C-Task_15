using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_15._3
{
    internal class Book
    {   
        public Book()
        {
            No++;
            _no = No;   
        }
        public static int No { get;set; }
        int _no;
        public string Name { get; set; }
        public int PageCount { get; set; }
        public string AuthorName { get;set;}

    }
}
