using System;

namespace TASK_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Ф.И.О.";//объявил переменные
            int age = 30;
            string main = "Email";
            double programm = 0.99;
            double math = 76.4;
            double physics = 64.2;
            Console.WriteLine(" {0} \n Возраст: {1} \n {2}: \n Баллы по программированию: {3} \n Баллы по матиматике: {4} \n Баллы по физике: {5}",
                              fullName, age, main, programm, math, physics);//форматированный вывод с переносом на новую строку для красоты.
            Console.ReadKey();//закрыть программу нажатием на любую клавишу.


        }
    }
}
