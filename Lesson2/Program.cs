using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string firstName;
            string lastName;
            string favoriteColor;
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your lastname: ");
            lastName = Console.ReadLine();

            //Console.WriteLine("Nice to meet you, " + firstName + " " + lastName + "!");
            //I'm just a comment
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();            
            Console.WriteLine("Nice to meet you {0} {1}, your favorite color is {2}.", firstName, lastName, favoriteColor);
            Console.ReadLine();
        }
    }
}
