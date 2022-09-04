using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork1
{
    class Program

    {
        static void Main(string[] args)
        {
            // a,b as long of square
            string name = Console.ReadLine();
            Console.Write("Enter a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Mult {a}*{b}={a * b}");

        Start1:
            Console.WriteLine("Do you want to diside a perimeter of this sqere?(YES or NO)");
            string answer = Console.ReadLine();
            if (answer ==  "YES" )
            {
                double c = a == b ? a * 4 : a * 2 + b * 2;
                Console.WriteLine(c);
            }
            else 
            {
                Console.WriteLine("I'm terrible sorry.");
                Console.WriteLine("End the Program? Tab anything");
            };
            //else
            //{
            //    Console.WriteLine(("Wrong answer.Start Againe"));
            //    Console.ReadKey();
            //    goto Start1;
            //}
        }
    }
}
