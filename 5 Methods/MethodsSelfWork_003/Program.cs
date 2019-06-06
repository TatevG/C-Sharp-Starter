using System;

namespace MethodsSelfWork
{
    class Program
    {
        static int Convert(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insert amount of money");
            int amount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insert convertation course");
            int convertationCourse = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your result is:");
            float result = Convert(amount, convertationCourse);
            Console.WriteLine(result);
        }
    }
}
