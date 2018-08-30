using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app will calculate the total of 10 numbers of your chosing.");

            float total = 0;
            for (int i = 1; i<= 10; i ++)

            {
                Console.Write($"Please enter a number {i}: ");
                total = total + float.Parse(Console.ReadLine());

            }

            Console.WriteLine($"The sum of the numbers you have entered is: {total}");

            Console.WriteLine("Thank you for playing, the game is now complete.");
            Console.WriteLine("Please press enter to continue.");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
