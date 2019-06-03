using System;

namespace LoopsSelfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, z = 1;

            /* example
                ******
                ******
                ******
                ******              
            */

            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            /* example
                *          
                **
                ***
                ****
                *****              
            */
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            int buf = b;

            /*example
                   *
                  ***
                 *****
                *******            
            */

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }
                b -= 1;
                z += 2;
                Console.WriteLine();
            }

            z = 1;

            /*example
                   *
                  ***
                 *****
                *******  
                 *****
                  ***
                   *
            */

            for (int i = 0; i < (a + a + 1); i++)
            {
                if (i < a)
                {
                    for (int j = 0; j < buf; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }
                    buf -= 1;
                    z += 2;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < buf; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }
                    buf += 1;
                    z -= 2;
                    Console.WriteLine();
                }
            }
        }
    }
}
