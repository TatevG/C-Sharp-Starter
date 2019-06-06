using System;

namespace MethodsSelfWork
{
    class Program
    {
        static void Calculate(ref int a, ref int b, ref int c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("insert number1");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("insert number2");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("insert number3");
            int number3 = Int32.Parse(Console.ReadLine());
            Calculate(ref number1, ref number2, ref number3);
            Console.WriteLine("after calculation {0}, {1}, {2}", number1, number2, number3);
        }
    }
}
