using System;

namespace ConditionSelfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Word:");
            string word = Console.ReadLine();

            switch (word)
            {
                case "Hello":
                    Console.WriteLine("{0} - Привет", word);
                    break;
                case "World":
                    Console.WriteLine("{0} - Мир", word);
                    break;
                case "Apple":
                    Console.WriteLine("{0} - Яблоко", word);
                    break;
                case "Computer":
                    Console.WriteLine("{0} - Комп", word);
                    break;
                case "System":
                    Console.WriteLine("{0} - Система", word);
                    break;
                case "Sun":
                    Console.WriteLine("{0} - Солнце", word);
                    break;
                case "Moon":
                    Console.WriteLine("{0} - Луна", word);
                    break;
                case "Tree":
                    Console.WriteLine("{0} - Дерево", word);
                    break;
                default:
                    Console.WriteLine("This word is absent from this dictionary");
                    break;
            }

        }
    }
}
