﻿using System;

// Оператор многозначного выбора - switch-case (переключатель). 

namespace Switch
{
    class Program
    {
        static void Main()
        {
            // Предлагаем пользователю ввести число.
            Console.WriteLine("Введите число 1 или 2: ");

            // Принимаем ввод от пользователя.
            string number = Console.ReadLine();


            // На 21 строке создаем конструкцию многозначного выбора, переключатель - switch, 
            // которому в качестве выражения-селектора, передаем переменную - number.

            switch (number)  // (number) — выражение-селектор.
            {
                // В теле переключателя switch-case, на 29 и 35 строках,
                // создаем два оператора case, c постоянными выражениями равными "1" и "2" соответственно.

                // Если значение выражения-селектора совпадет с одним из значений постоянных выражений,
                // то выполняется тело оператора case, постоянное выражение которого, совпало с выражением-селектора. 

                case "1":    // "1" — постоянное выражение.
                    {
                        Console.WriteLine("Один");                                       // Ветвь 1
                        // Выход из переключателя.
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Два");                                        // Ветвь 2
                        break;
                    }

                // На 44 строке создаем (необязательный) оператор default, тело которого выполняется в случае,
                // если значение выражения-селектора не совпадет ни с одним из значений постоянных выражений. 

                default:
                    {
                        Console.WriteLine("Вы ввели значение отличное от 1 и 2.");       // Ветвь 3
                        break;
                    }

                    // Если в переключателе отсутствует оператор default, то управление передается за пределы переключателя switch.    
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
