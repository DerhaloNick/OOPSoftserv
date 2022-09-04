using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string answer;
            Console.WriteLine("What is radius of circle ?");
            string answer_1 = Console.ReadLine();
            double r = Convert.ToDouble(answer_1);
            double b = 3.14;
            Console.WriteLine("Press Enter to make leight");
            Console.ReadKey();
            Console.WriteLine($"Leight {r} * {b}*2={r * b * 2}");
            Console.ReadKey();
            Console.WriteLine("Press Enter to make Area");
            Console.ReadKey();
            Console.WriteLine($"Area {b} * {r}*{r}={b * r * r}");
            Console.ReadKey();
            double c = 4 / 3;
            Console.WriteLine("Press Enter to make Volume");
            Console.ReadKey();
            Console.WriteLine($"Volume {c}*{b}*{r}*{r}={c * b * r * r * r}");
            Console.ReadKey();
            Console.WriteLine("Thank You.Have a good day");
            Console.ReadKey();
        }
    }
}
