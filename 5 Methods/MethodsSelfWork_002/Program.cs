using System;

namespace MethodsSelfWork
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static float Div(int a, int b)
        {
            return a / b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insert second number");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insert sign");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    int sum = Add(number1, number2);
                    Console.WriteLine("Sum is {0}", sum);
                    break;
                case "-":
                    int sub = Sub(number1, number2);
                    Console.WriteLine("Sub is {0}", sub);
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        float div = Div(number1, number2);
                        Console.WriteLine("Div is {0}", div);
                    }
                    Console.WriteLine("Can't Divide to 0");
                    break;
                case "*":
                    int mul = Mul(number1, number2);
                    Console.WriteLine("Mul is {0}", mul);
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }
        }
    }
}
