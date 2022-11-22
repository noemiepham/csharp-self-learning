using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <sumary>
        ///</summay>
        /// <param name='args'> An array of string arguments from the command line </param>
        ///<return>
        static void Main(string[] args)
        {
            // single line commets start with two slashes
            // you can have as many of these as you want
            Console.WriteLine("Hello World!");
            /* Multiple line comments start with a slash and a 
            star and can continue for several lines
            until a closing star and slash are encountered */

        }
    }
}
