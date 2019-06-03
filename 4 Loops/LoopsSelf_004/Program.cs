using System;

namespace LoopsSelfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, res = 1;

            do
            {
                res *= a--;

            } while (a > 0);

            Console.WriteLine(result);
        }
    }
}
