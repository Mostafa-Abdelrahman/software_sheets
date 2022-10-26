using System;

namespace index
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("enter the size of arr : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int sum=0;
            Console.WriteLine("enter "+size+" number to sum : ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("the sum is : " + sum);
        }
    }
}
