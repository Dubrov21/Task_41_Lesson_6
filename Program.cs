

using System;

namespace Task_41_Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int count = 0;
            int number = 0;
            while (true)
            {
                Console.WriteLine("Введите целое число или любую букву для окончания ввода");
                if(int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                    {
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine($"Количество введённых положительных чисел равно {count}");
                    break;
                }
            }
            

        }
    }
}
