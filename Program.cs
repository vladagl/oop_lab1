using System;

namespace oop_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розрахуємо індекс маси тіла. Напишіть свою вагу:");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Напишіть свій ріст (в метрах через крапку):");
            int height = Convert.ToInt32(Console.ReadLine());

            int result = weight / (height * height);

            if (result <= 18)
            {
                Console.WriteLine($"Ваш ІМТ: {result}. Недостатня маса тіла.");
            }
            else if (result > 18 && result <= 24)
            {
                Console.WriteLine($"Ваш ІМТ: {result}. Нормальна вага.");
            }
            else if (result > 24 && result <= 29)
            {
                Console.WriteLine($"Ваш ІМТ: {result}. Надлишкова вага.");
            }
            else if (result >= 30)
            {
                Console.WriteLine($"Ваш ІМТ: {result}. Ожиріння, звернись до лікаря.");
            }
        }
    }
}
