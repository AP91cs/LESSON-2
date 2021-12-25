using System;

namespace TASK_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double programm = 0.99;//объявил переменные,без них никак.
            double math = 76.4;
            double physics = 64.2;
            Console.WriteLine(" Баллы по программированию:{0} \n Баллы по матиматике:{1} \n Баллы по физике:{2} ",
                              programm, math, physics);//форматированный вывод.
            Console.ReadKey();//последовательный вывод по нажатию клавиши(вот только символ остается пришлось переносить на следующую сторку для красоты)
            double sum = programm + math + physics;//объявил переменную суммы баллов.
            double average = sum / 3;//объявил переменную среднее арифметическое.
            Console.WriteLine("\n Сумма баллов: {0} \n Среднее арифмитическое баллов: {1}", sum, average);//форматированный вывод.
            Console.ReadKey();
        }
    }
}
