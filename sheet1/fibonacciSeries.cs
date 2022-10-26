using System;

namespace index
{
    internal static class Program
    {
        
        private static void Main(string[] args)
        {
            int n, n1=0, n2=1, final;
            Console.Write("enter the number of terms : ");
            n =Convert.ToInt32( Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if(i==0)
                    Console.Write(0+" ");
                else if(i==1)
                    Console.Write(1+" ");
                else
                {
                    final = n1 + n2;
                    n1 = n2;
                    n2 = final;
                    Console.Write(final+" ");
                }

            }
        }
    }
}
