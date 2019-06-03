using System;

// Оператор безусловного перехода - goto.

namespace GoTo
{
    class Program
    {
        static void Main()
        {

        // Label - это метка, на которую будет произведен переход оператором goto.

        Label: Console.WriteLine("Hello!");
            goto Label;

        }
    }
}
