using System;

namespace ConditionSelfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first operand");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second operand");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert sign operand");
            string sign = Console.ReadLine();

            switch(sign)
            {
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Can't divide to 0");
                        break;
                    }
                    Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
                    break;
                default:
                    Console.WriteLine("Wrong sign or operands");
                    break;
            }

        }
    }
}
