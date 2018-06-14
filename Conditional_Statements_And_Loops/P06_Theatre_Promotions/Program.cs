using System;

namespace P06_Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int priceTicket = 0;

            if (age >= 0 && age <= 18)
            {
                switch (typeDay)
                {
                    case "Weekday":
                        priceTicket = 12;
                        break;
                    case "Weekend":
                        priceTicket = 15;
                        break;
                    case "Holiday":
                        priceTicket = 5;
                        break;
                }
                        Console.WriteLine(priceTicket + "$");
            }
            else if (age > 18 && age <= 64)
            {
                switch (typeDay)
                {
                    case "Weekday":
                        priceTicket = 18;
                        break;
                    case "Weekend":
                        priceTicket = 20;
                        break;
                    case "Holiday":
                        priceTicket = 12;
                        break;
                }
                Console.WriteLine(priceTicket + "$");
            }
            else if (age > 64 && age <= 122)
            {
                switch (typeDay)
                {
                    case "Weekday":
                        priceTicket = 12;
                        break;
                    case "Weekend":
                        priceTicket = 15;
                        break;
                    case "Holiday":
                        priceTicket = 10;
                        break;
                }
                Console.WriteLine(priceTicket + "$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
