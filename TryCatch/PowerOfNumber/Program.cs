using System;

namespace PowerOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pow pow = new Pow();
                Console.WriteLine("Please enter the x number:");
                long number = long.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the y index: ");
                long index = long.Parse(Console.ReadLine());
                Console.WriteLine("The result is: ");
                Console.WriteLine(pow.getPow(number, index));
            }
            catch
            {
                Console.WriteLine("Need to enter numbers in the long range");
            }
            Console.ReadLine();
        }
    }

    class Pow
    {
        public long getPow(long n, long index)
        {
            long result = n;
            for (long i = 0; i < index; i++)
            {
                result *= n;
            }
            return result;
        }
    }
}
