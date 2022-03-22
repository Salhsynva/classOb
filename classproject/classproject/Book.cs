using System;
using System.Collections.Generic;
using System.Text;

namespace classproject
{
    class Book:Product
    {
        public Book(string genre, int no, string name, double price):base(no ,name, price) 
        {
           
        }
        
        public string Genre;
    }
}
