using System;
using System.Collections.Generic;

namespace FibWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Fib fibonacci = new Fib();
            List<int> fib = new List<int>(){
                1
            };
            int index = 0;
            Console.WriteLine("Ten first elements in fibonacci sequence:");
            while (fib.Count <= 10)
            {
                fib.Add(fibonacci.getFib(fib[index], index - 1 < 0 ? fib[0] : fib[index - 1]));
                Console.WriteLine(fib[index]);
                index++;
            }
            Console.ReadLine();
        }
    }

    public class Fib
    {
        public int getFib(int n, int n2)
        {
            return n += n2;
        }
    }
}
