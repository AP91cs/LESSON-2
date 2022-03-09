using System;

namespace TASK_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputParse = Console.ReadLine();
            static void ReversWords (string inputParse)
           { 
               string [] arr = SplitPharse(inputParse);
                static string[] SplitPharse(string inputPharse)
                {
                    string[] arr = inputPharse.Split(' ');
                    return arr;
                }

                Array.Reverse(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]}" + " ");
                }
           }
            ReversWords(inputParse);
            Console.ReadKey();
           
        } 
    }
}
