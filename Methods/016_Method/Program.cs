using System;

namespace Methods
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void DrawRectangle(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int sum = Add(2, 5);
            Console.WriteLine(sum);
            DrawRectangle(8, 3);
            DrawRectangle(7, 7);
            DrawRectangle(4, 3);
        }
    }
}
