using System;

namespace TASK_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string picture;
            
            int sum = 0;

            Console.WriteLine("\n Привет! \n Сколько у Вас карт?");
            int card = int.Parse(Console.ReadLine());
            Console.WriteLine(" Для карт с цифровым наминалом введите цифру. \n Для картинок: \n Валет - J; \n Дама - Q; \n Король - K; \n Туз -T.");
            
            for (int i = 1; i <= card; i++)
            {

                Console.WriteLine("Введите Вашу карту:");
                picture = Console.ReadLine();
                switch (picture)
                {
                    case "J": sum += 10; break;
                    case "Q": sum += 10; break;
                    case "K": sum += 10; break;
                    case "T": sum += 10; break;
                    case "2": sum += 2; break;
                    case "3": sum += 3; break;
                    case "4": sum += 4; break;
                    case "5": sum += 5; break;
                    case "6": sum += 6; break;
                    case "7": sum += 7; break;
                    case "8": sum += 8; break;
                    case "9": sum += 9; break;
                    case "10": sum += 10; break;
               
                }
            } 

            Console.WriteLine($"Сумма Ваших карт {sum}");
            Console.ReadKey();
        }
    }
}

