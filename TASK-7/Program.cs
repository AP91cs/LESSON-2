using System;

namespace TASK_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;//2147483647
            Console.Write("Введите длину последовательности:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];//одномерный массив содержащий длину последовательности
            for (int i = 0; i < arr.Length; i++)//заполнение массива
            {
                Console.Write($"Введите число:");
                arr[i] = int.Parse(Console.ReadLine());//заполняем массив числами которые ввел пользователь
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Наименьший элемент : {min}");
            Console.ReadKey();
            
        }
    }
}
