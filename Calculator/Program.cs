using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer:");

            while (true)
            {
                var primer = Console.ReadLine();
                if (primer == "exit") break;
                Console.WriteLine(Calculate.CalculatePrimer(primer));
            }
            
        }

        
        
    }
}
