using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.Lab_5
{
    class Program
    {
        public static long uNum { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Factoral calculator");
            //set var
            string userNumber;
            int x;
            long factorial;
            string check;

            while (true)
            {
                //get int
                Console.Write("Enter an integer: ");
                userNumber = Console.ReadLine();
                x = int.Parse(userNumber);

                factorial = getFactorial(x);

                Console.WriteLine("Factorial of " + userNumber + " is " + factorial);

                //Check
                Console.Write("Continue y/n: ");
                check = Console.ReadLine();
                if (check != "y")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }

        }

        static long getFactorial(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            {
                return (x * getFactorial(x - 1));
            }
           
        }

    }
}
