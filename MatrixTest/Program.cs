using System;

class Program
{
    static void Main(string[] args)
    {
        int x, y;

        // Запрашиваем у пользователя ввод двух чисел
        Console.WriteLine("Введите два целых числа:");
        if (!int.TryParse(Console.ReadLine(), out x) || !int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Ошибка: Введите корректные целые числа.");
            return;
        }

        // Проверяем, что введенные числа положительные
        if (x <= 0 || y <= 0)
        {
            Console.WriteLine("Ошибка: Введите положительные числа.");
            return;
        }

        // Создаем и выводим матрицу умножения
        Console.WriteLine("Матрица умножения для {0}x{1}:", x, y);
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= y; j++)
            {
                Console.Write("{0,4}", i * j); // Форматируем вывод, чтобы матрица была красиво отформатирована
            }
            Console.WriteLine();
        }
    }
}
