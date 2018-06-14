using System;

namespace P09_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.Write("Write an input to show Multiplication Table to this number ==> ");
            int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= input; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i}.{j}={i*j}");
            //    }
            //    Console.WriteLine(" ");
            //}
            
            ///WHILE LOOP

            int i = 1;               

            while (i <= 10)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
                i++;
            }
        }
    }
}
