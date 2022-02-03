using System;

namespace TASK_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите масксимальное число:");
            int max = int.Parse(Console.ReadLine());
            Random ran = new();
            int i= ran.Next(0,max);
            int j = 0;
            while (true)
            {
                j++;
                Console.Write("Введите загаданное число:");
                var number = Console.ReadLine();
                if (number=="")
                {
                    Console.WriteLine($"Загаданное число было : {i}");break;
                }
                int f = int.Parse(number);
                    if (f > max)
                    {
                        Console.Write("Введите загаданное число:");

                    }
                    else if (i < f)
                    {
                        Console.WriteLine("Ваше число больше загаданного!");

                    }
                    else if (i > f)
                    {
                        Console.WriteLine("Ваше число меньше загаданного!");

                    }
                    else if (i == f)
                    {
                        Console.WriteLine("Вы угадали!!!");
                        break;
                    }
                
            }

            Console.ReadKey();

        }
    }
}
