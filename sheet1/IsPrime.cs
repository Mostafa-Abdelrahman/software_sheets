using System;

namespace index
{
    internal static class Program
    {
        private static bool IsPrime(int num)
        {
            for (int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
        private static void Main(string[] args)
        {
            // put the number to test it 
            int num = 7;
            // check if prime or not 
            if (IsPrime(num))
                Console.WriteLine("Prime number");
            else
            {
                Console.WriteLine("not Prime number");
            }
        }
    }
}
