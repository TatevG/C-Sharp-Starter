using System;

// Циклическая конструкция - for (цикл со счетчиком).

namespace For
{
    class Program
    {
        static void Main()
        {

            // for ( Инициализация счетчика итераций; Условие; Изменение счетчика ) { Тело цикла }

            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);
            }

            //counter = 0; //  counter - недоступен за пределами цикла for.

            // Delay.
            Console.ReadKey();
        }
    }
}
