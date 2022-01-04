using System;

namespace TASK_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите  число:");//просим ввести число
            int num = int.Parse(Console.ReadLine());//строку в число
            int i = 1;//начало счетчика
            while(i<num-1)//счеткик от 1 и до числа пользователя минус один
            {   i++;//плюс 1
                
                bool res = num % i!= 0;//переменная ложь
                

                    if (!res)//если истина
                    {
                        Console.WriteLine("Не является простым числом!");//вывод на экран
                    break;
                    }
                    else//ложь
                    {
                    Console.WriteLine($"Простое число!") ; 
                        break;
                    }
                
            }
            
            Console.ReadKey();
            
        } 
    }
}
