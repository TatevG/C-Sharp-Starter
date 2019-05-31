using System;

namespace TypesSelfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double vol = 0, sqrt = 0, r = 5, h = 8;
            const float pi = 3.141f;
            vol = pi * r * r * h;
            sqrt = 2 * pi * r * (r + h);

            Console.WriteLine("Volume is {0}, and Square is {1}", vol, sqrt);
        }
    }
}
