using System;

namespace MethodsSelfWork
{
    class Program
    {
        static void Creditbt(ref int a)
        {
            if (a == 700)
            {
                Console.WriteLine("Credit is Closed");
            }
            else if (a < 700)
            {
                Console.WriteLine("Still must pay {0}", 700 - a);
            }
            else
            {
                Console.WriteLine("Credit is cloded");
                Console.WriteLine("Overpayment is {0}", a - 700);
            }
        }

        static void Main()
        {
            Console.Write("Insert credit payment amount:");
            int a = Convert.ToInt32(Console.ReadLine());

            Creditbt(ref a);
        }
    }
}
