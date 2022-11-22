﻿using System;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new Book instance
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // In previous example, this would fail, but will now
            // work since the field name is declared as public
            // b1._name = "Cat in the Hat";
            // Console.WriteLine(b1.GetDescription());

            // TODO: set data using functions instead of accessing fields directly
            b1.SetName("Xin Loi May Bento");
            b1.SetAuthor("Nguyen Nhat Anh");
            b1.SetPagecount(500);

            Console.WriteLine(b1.GetDescription());
        }
    }
}
