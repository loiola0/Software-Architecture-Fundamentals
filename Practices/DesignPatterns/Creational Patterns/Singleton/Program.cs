using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair firstChair = Chair.Instance;

            firstChair.Quantity = 7;


            Chair secondChair = Chair.Instance;
            
            secondChair.Quantity = 3;

            Console.WriteLine($"The chair number is {firstChair.Quantity}");
            Console.WriteLine($"The chair number is {secondChair.Quantity}");

        }
    }
}
