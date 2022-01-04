using System;

namespace TASK_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое чило:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Вы ввели четное число!");
            }
            else Console.WriteLine("Вы ввели нечетное число!");
            Console.ReadKey();
            
        }
    }
}
