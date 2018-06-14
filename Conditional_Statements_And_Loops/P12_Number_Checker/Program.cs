using System;

namespace P12_Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
            int input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");              
            }
        }
    }
}
