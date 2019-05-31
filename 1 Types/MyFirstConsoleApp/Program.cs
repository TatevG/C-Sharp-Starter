using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Тип данных C# (псевдоним)
                byte a = 2;

                // Системный тип данных
                Byte b = 2;

                // Вывод значений переменных на экран.
                Console.WriteLine(a);
                Console.WriteLine(b);

                // Задержка.
                Console.ReadKey();
            }
        }
    }
}
