using System;

namespace LoopsSelfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 10, width = 50;
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
