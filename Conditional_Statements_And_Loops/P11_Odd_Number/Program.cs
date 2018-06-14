using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 0;

            while (i<=10)
            {
                n = int.Parse(Console.ReadLine());

                if (n % 2 != 0)
                {
                    break;
                }
                Console.WriteLine("Please write an odd number.");
                i++;
            }
            Console.WriteLine($"The number is: " + Math.Abs(n));
        }
    }
}



