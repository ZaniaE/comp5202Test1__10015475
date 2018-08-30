using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("This app will expand a basic quadratic equation containing two values of your chosing.");
            Console.WriteLine("The quadritic equation will be structured as such: (x+a)(x+b)");

            Console.WriteLine("Based off of the equation above...");

            Console.WriteLine("Enter a positive or negative value to replace a: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a positive or negative value to replace b: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"That equation in standard form is: x^2 + {num1 + num2} x + {num1*num2} ");
            Console.WriteLine("Thank you for playing, the game is complete.");
            Console.WriteLine("Please press enter to continue.");
            Console.ReadLine();
            Console.Clear();


        }
    }
}
