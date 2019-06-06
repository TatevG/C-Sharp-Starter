using System;

namespace MethodsSelfWork
{
    class Program
    {
        static int Factorial(int n)
        {
            if( n< 0)
            {
                return 0;
            }
            else
            {
                if (n != 0)
                {
                    return n * Factorial(n - 1);

                }

                return 1;
            }

        }

        static void Main()
        {
            Console.WriteLine("Insert number");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = Factorial(number);

            Console.WriteLine("The ways count is equal to {0}", factorial);
        }
    }
}