using System;

namespace Calculate
{
    class Program
    {
        static float Calculate(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number");
            int number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number");
            int number2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insert third number");
            int number3 = Int32.Parse(Console.ReadLine());

            float result = Calculate(number1, number2, number3);
            Console.WriteLine("Resutl is {0}", result);
        }
    }
}
