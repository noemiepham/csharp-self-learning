using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 50;

            // TODO: if-else 
      /*       if (theVal == 50) {
                Console.WriteLine("TheVal is 50");
            }
            else {
                Console.WriteLine("TheVal is sommething else");
            } */
            Console.WriteLine(theVal == 50 ? "Theval is 50" : "Theval is sommething else");


            // -----------------------
            // TODO: Using the ternary operator ?:

            // a two-case if-then
            /*
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }
            */

            // TODO: can be replaced by a ternary operator ?:

        }
    }
}
