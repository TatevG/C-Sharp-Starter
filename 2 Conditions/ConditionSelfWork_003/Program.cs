using System;

namespace ConditionSelfWork_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if ((number >= 0) && (number <= 14))
            {
                Console.WriteLine("number is in [0 - 14]");
            }
            else if ((number >= 15) && (number <= 35))
            {
                Console.WriteLine("number is in [15 - 35]");
            }
            else if ((number >= 36) && (number <= 50))
            {
                Console.WriteLine("number in in [36 - 50]");
            }
            else if ((number >= 50) && (number <= 100))
            {
                Console.WriteLine("number is in [50 - 100]");
            }
            else
            {
                Console.WriteLine("Given number is greather than 100 or less than 0");
            }
        }
    }
}
