using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHelloMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello("Max", "Arnold");
        }
        /// <summary>
        /// Print Hello World to the console.
        /// </summary>
        /// <param name="= first">The first name</param>
        /// <param name=" last">The last name</param>
        static void SayHello(String first, String last)
        {
            Console.WriteLine("Hello" + " " + first + " " + last);

        }
    }
}
