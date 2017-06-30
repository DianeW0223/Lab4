using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run == true)
            {
                Console.WriteLine("Please enter a whole number between 1 and 10");
                long num = long.Parse(Console.ReadLine());
                long factorial = 1;

                for (long i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("The factorial of " + num + " is: " + factorial);
                run = Continue();
            }
        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
    }
}

