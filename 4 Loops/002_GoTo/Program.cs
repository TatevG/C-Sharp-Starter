﻿using System;

// Оператор безусловного перехода - goto.

namespace GoTo
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

        Label:
            counter++;
            Console.WriteLine("Counter = {0}", counter);

            if (counter < 3)
            {
                goto Label;
            }

            Console.WriteLine("End");

            // Delay.
            Console.ReadKey();
        }
    }
}
