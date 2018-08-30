using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app will tell you if a number is odd or even.");
            Console.WriteLine("Please enter a whole number between 1 and 1000: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("That number is even.");
            else
                Console.WriteLine("That number is odd.");

            Console.WriteLine("The game is complete, please press enter to continue.");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
