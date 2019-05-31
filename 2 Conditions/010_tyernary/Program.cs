﻿using System;

// Тернарная условная операция. Вложенные тернарные операторы.

namespace Ternary
{
    class Program
    {
        static void Main()
        {
            // Определение квадранта в котором лежит заданная точка.
            // Для упрощения примера условимся, что точка не будет лежать в центре координат и на координатных осях,
            // это значит, что x и y - не могут быть равны 0.

            int x = 10, y = -5;


            // Не рекомендуется вкладывать тернарные операторы, так как это ухудшает чтение кода.


            string quadrant = (x > 0) ? ((y > 0) ? "I квадрант" : "IV квадрант") : ((y > 0) ? "II квадрант" : "III квадрант");

            // ... или так

            quadrant = x > 0 ? (y > 0 ? "I квадрант" : "IV квадрант") : (y > 0 ? "II квадрант" : "III квадрант");

            // ... или вообще, вот так

            quadrant = x > 0 ? y > 0 ? "I квадрант" : "IV квадрант" : y > 0 ? "II квадрант" : "III квадрант";


            Console.WriteLine(quadrant);

            // Delay.
            Console.ReadKey();
        }
    }
}
