using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("war and peace","Leo", 825);
            Book b2 = new Book("The start war", " Jorge Luca", 468);
            
            // TODO: Call a method on the object
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());


            // TODO: try to set one of the properties -- 
            // this will result in an error
            //b1._name = "Aldous Huxley";

        }
    }
}
