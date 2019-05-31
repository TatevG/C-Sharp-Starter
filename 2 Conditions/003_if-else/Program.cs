using System;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;

            // Если тело блока if или else состоит из одного выражения, то операторные скобки можно опустить

            if (a < b)
                Console.WriteLine("a < b");           // Ветвь 1 
            else
                Console.WriteLine("a не меньше b");   // Ветвь 2

            // Delay.
            Console.ReadKey();
        }
    }
}
