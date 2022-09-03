using System.Threading.Tasks;

namespace Hometask1Derhalo
{
    class program
    {
        static void Main(string[] args)
        {
            // make 4 args
            string name = Console.ReadLine();
        Link:
            Console.Write("Enter any a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter digit numbers b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter any c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter digit numbers d = ");
            double d = Convert.ToDouble(Console.ReadLine());
            if ((b % 2 == 0) && (d % 2 == 0))
            {
                Console.WriteLine("Sum {0} + {1} + {2} + {3} = {4}", a, b, c, d, a + b + c + d);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("ENTERED UNCORRECT DIGITS NUMBERS b.d, Try again . ");
                Console.ReadKey();
                {
                    goto Link;
                }
            }
            // make new rouls - if more then 20 - task1 part 2 , alse - Task1 part3
            {
            Link1:
                Console.WriteLine("GOOD.TAB ANY NUMBERS TO CONTINUE.MORE THEN 20 IF YOU'D LIKE TO SUB OR LITTLE IF YOU'D LIKE TO MULT");
                double f = Convert.ToDouble(Console.ReadLine());
                //string f = ("{4}");
                //double y = Convert.ToDoubl(f);
                if (f > 20)
                {
                    Console.WriteLine("Sub " + a + "-" + b + "+" + c + "-" + d + "=" + (a - b + c - d));
                    Console.ReadKey();
                    {
                        goto Link1;
                    }
                }
                else
                    Console.WriteLine($"Mult {a}*{b} = {a * b}");
                Console.ReadKey();
                Console.WriteLine("GOOD.HOW ARE YOU? (GOOD or NOT GOOD");
                string answer = Console.ReadLine();
                if (answer == "GOOD")
                    Console.WriteLine($"I'M GLAD, THET YOU ARE GOOD.");
                if (answer == "NOT GOOD")
                    Console.WriteLine($"I'M TARIBLE SORRY, THET YOU ARE NOT GOOD.");
                }
            }
        }
    }
