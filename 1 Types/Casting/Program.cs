﻿using System;

// Преобразование типа (Casting или Type conversion) - это преобразование значения переменной одного типа в значение другого типа.
// Выделяют явное (explicit) и неявное (implicit) преобразование типов.

namespace Casting
{
    class Program
    {
        static void Main()
        {
            //   ----------------------------------  Variables  ---------------------------------------------

            #region Implicit (safe) type conversation:

            // Неявное преобразование значения типа - byte в тип int. (преобразование меньшего типа в больший) 
            byte a = 10;     //                                      0000 1010  -  1 byte
            int b = 0;       //  0000 0000   0000 0000   0000 0000   0000 0000  -  4 byte
            b = a;           //  0000 0000   0000 0000   0000 0000   0000 1010  -  4 byte

            Console.WriteLine(b);

            // Неявное преобразование значения типа - int в тип float. (преобразование целого типа в вещественный) 
            int c = 255;
            float d = 0f;
            d = c;

            Console.WriteLine(d);

            #endregion

            #region Explicit (danger) type conversation:

            // Явное преобразование значения типа - int в тип byte. 
            // (преобразование большего типа в меньший, приводит к потере части результата)            

            int e = 256;     //  0000 0000   0000 0000   0000 0001   0000 0000  -  4 byte
            byte f = 0;      //                                      0000 0000  -  1 byte
            f = (byte)e;     //                                      0000 0000  -  1 byte
            // f = e;        //  ERROR.

            Console.WriteLine(f);

            // Явное преобразование значения типа - float в тип int.  
            // (преобразование вещественного типа в целый, приводит к потере точности результата)

            float g = 10.5F;
            int h = 0;
            h = (int)g;
            // h = g;         // ERROR.

            Console.WriteLine(h);

            #endregion

            //   ----------------------------------  Constants  ----------------------------------------------

            #region Casting constant

            // Возможно неявное преобразование значения константы типа - int в тип byte,
            // при инициализации переменной значением константы,
            // если значение константы не превышает максимально допустимого значения переменной.

            const int i = 255;  //  0000 0000   0000 0000   0000 0000   1111 1111  -  4 byte
            byte j = 0;         //                                      0000 0000  -  1 byte
            j = i;              //                                      1111 1111  -  1 byte

            Console.WriteLine(j);

            // Возможно явное преобразование значения константы типа - float в тип byte, 
            // при инициализации переменной значением константы,
            // если значение константы не превышает максимально допустимого значения переменной.

            const float k = 255;
            byte l = 0;
            l = (byte)k;

            Console.WriteLine(l);


            // Невозможно ни явное, ни неявное преобразование значения константы,
            // при инициализации переменной значением константы,
            // если значение константы превышает максимально допустимый диапазон значения переменной.

            const int m = 256;  //  0000 0000   0000 0000   0000 0001   0000 0000  -  4 byte
            byte n = 0;         //                                      0000 0000  -  1 byte
            // n = m;           //  ERROR.
            // n = (byte)m;     //  ERROR.

            Console.WriteLine(n);

            // Невозможно ни явное, ни неявное преобразование значения вещественной константы,
            // при инициализации целочисленной переменной значением константы,
            // если значение константы превышает максимально допустимый диапазон значения переменной.

            const float o = (float)256.5; // преобразование double в float
            byte p = 0;
            // p = o;           //  ERROR.
            // p = (byte)o;     //  ERROR.

            Console.WriteLine(p);

            #endregion
        }
    }
}
