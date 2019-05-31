using System;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 2;

            if (a < b)  // Если условие удовлетворяет истинности, выполняем тело блока if.
            {
                Console.WriteLine("a < b");               // Ветвь 1
            }
            else        // Иначе, выполняем тело блока else.       
            {
                Console.WriteLine("a не меньше b");       // Ветвь 2
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
