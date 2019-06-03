using System;

namespace LoopsSelfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 59, c = 12, d = 54, sum = 0;
            do
            {
                sum += a;
                a++;
            }
            while (b > a);
            Console.WriteLine("Sum is ", sum);
            Console.WriteLine("Odd numbers are");
            for(int i = c; i < d; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
