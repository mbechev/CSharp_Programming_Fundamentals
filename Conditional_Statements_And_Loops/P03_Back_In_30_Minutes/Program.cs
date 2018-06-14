using System;

namespace P03_Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int addMin = minutes + 30;
            if (addMin > 59)
            {
                hours += 1;
                addMin -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{addMin:d2}");
        }
    }
}
