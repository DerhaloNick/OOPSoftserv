HomeWork1

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
            Console.WriteLine("Do you want to decide a perimeter of this sqere?(YES or NO)");
            string answer = Console.ReadLine();
            if (answer != " YES ")
            {
                double c = a == b ? a * 4 : a * 2 + b * 2;
                Console.WriteLine(c);
            }
            if (answer != " NO ") ;
            else
            {
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

HomeWork2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_Task_02
{
    class Program
    { static void Main(string[] args)
        {
            //string answer;
            Console.WriteLine("What is your name?");
            string answer_1 = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string answer_2 = Console.ReadLine();
            Double a = Convert.ToDouble(answer_2);
            Console.WriteLine($"You name are {answer_1};Your age are {answer_2}");
            {
                if (a > 18)
                Console.WriteLine("What is your second name?");
                string answer_3 = Console.ReadLine();
                Console.WriteLine($"You name are {answer_1};Yor second name are {answer_3}; Your age are {a}");
                Console.ReadKey();
                if (a < 18)
                    Console.WriteLine("Sorry,we coud not speake with you");
                    Console.ReadKey();
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    { static void Main(string[] args)
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
