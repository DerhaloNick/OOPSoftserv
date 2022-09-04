using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_Task_02
{
    class Program
    {
        static void Main(string[] args)
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
