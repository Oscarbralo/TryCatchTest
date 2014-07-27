using System;

namespace PowerOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the x number:");
                long number = long.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the y index: ");
                long index = long.Parse(Console.ReadLine());
                Console.WriteLine("The result is: ");
                Console.WriteLine(Math.Pow(number, index));
            }
            catch
            {
                Console.WriteLine("Need to enter numbers in the long range");
            }
            Console.ReadLine();
        }
    }
}
