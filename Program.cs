/*
File Name: arnolndmx_InClass2.27.2025
Name: Mariah Jenkins
email: Jenkim3@mail.uc.edu
Assignment Number: In Class 3/27/2025
Due Date: 3/27/2025   
Course #/Section: 001
Semester/Year: Spring Semester '25
Brief Description of the assignment:  Clone a github
Brief Description of what this module does. 
Citations: N/A
Anything else that's relevant: N/A
*/
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
            Console.WriteLine("Hello" + " " + "Mariah Jenkins");
        }
    }
}
