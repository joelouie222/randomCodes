using System;

namespace ISTA_220_EX_Cs_Ch5_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastlastVal = 0;
            int lastVal = 1;
            int currentVal;

            Console.WriteLine("The Fibonacci Numbers");

            for (int i = 1; i <= 20; i++) //Only the first 20
            {
                    currentVal = lastVal + lastlastVal;
                    Console.WriteLine($"F[{i}] = {lastlastVal}");
                    lastlastVal = lastVal;
                    lastVal = currentVal;
            }
        }
    }
}
