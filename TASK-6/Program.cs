using System;

namespace TASK_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк:");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов:");
            int pillar = int.Parse(Console.ReadLine());
            int[,] matrix = new int[line,pillar];
            Random num = new();
            int sum = 0;
            for (int i = 0; i < line; i++)
            {
                
                for (int j = 0; j < pillar; j++)
                {
                    matrix[i, j] = num.Next(1,10);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();  
            }
            Console.WriteLine($"Сумма всех чисел равна : {sum} ");
            
            Console.ReadKey();
        }
            
    }
}
