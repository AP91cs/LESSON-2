using System;

namespace TASK_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите предложение:");
            string str = Console.ReadLine();
            static string[] ArrStr(string str)
            {
                string[] arr = str.Split(' ');
                return arr;
            }
            string [] arr = ArrStr(str);

            static void NewStr (string [] arr)
            {
                foreach (var item in arr)
                {
                    Console.WriteLine($"{item}");
                }
                
            }
            NewStr(arr);
            Console.ReadKey();

        }
    }
}
