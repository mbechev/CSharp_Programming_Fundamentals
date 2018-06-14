using System;

namespace P10_Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());              
            int multipl = int.Parse(Console.ReadLine()); 

            if (multipl>10)
            {
                Console.WriteLine($"{input} X {multipl} = {input * multipl}");
            }

            else
            {
                while (multipl<=10)
                {
                    Console.WriteLine($"{input} X {multipl} = {input*multipl}");
                    multipl++;
                }
            }        
        }
    }
}
