using System;

namespace MethodsSelfWork
{
    class Program
    {
        static void NumberInfo(int a)
        {
            if (a > 0)
            {
                Console.WriteLine("{0} is positive", a);
            }
            else
            {
                Console.WriteLine("{0} number is negative", a);
            }
            if ((a % 2 == 0) && (a % 5 == 0) && (a % 3 == 0) && (a % 6 == 0) && (a % 9 == 0)) {
                Console.WriteLine("{0} number is divide to 2, 5, 3 , 6, 9", a);
            }
            else
            {
                Console.WriteLine("{0} number is not divide to 2, 5, 3 , 6, 9", a);
            }
            int divider;
            int remainder;
            divider = 2;

            do
            {
                remainder = a % divider;

                if (remainder != 0)
                    divider++;
            }
            while (remainder != 0);

            if (divider == a)
            {
                Console.WriteLine("{0} is simple", a);
            }
            else
            {
                Console.WriteLine("{0} is not a simple", a);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number");
            int number = Int32.Parse(Console.ReadLine());
            NumberInfo(number);
        }
    }
}
