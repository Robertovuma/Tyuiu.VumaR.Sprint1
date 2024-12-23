
using Tyuiu.VumaR.Sprint1.Task6.V9.Lib;

namespace Tyuiu.VumaR.Sprint1.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Roberto | ИИПБ-24-2";
            //Длина строки 75 символов
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #1                                                           *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                    *");
            Console.WriteLine("* Задание #0                                                          *");
            Console.WriteLine("* Вариант #14                                                          *");
            Console.WriteLine("* Выполнил: Roberto |                 *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 2*3*3+7             *");
            Console.WriteLine("* и печатает результат на экране.                                     *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* 2*3*3+7                                                             *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                          *");
            Console.WriteLine("***********************************************************************");


            Console.WriteLine("Введите текст: ");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Слова с перенесенными последними буквами в начало:");
            Console.WriteLine(ds.MoveLetterToStart(value));
            Console.ReadKey();
        }
    }
}
