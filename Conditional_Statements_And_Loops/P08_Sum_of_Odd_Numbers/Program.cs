using System;

namespace P08_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 1;
            int i = 0;

            while (i < input)
            {
                sum += count;
                Console.WriteLine(count);
                count += 2;
                i++;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
