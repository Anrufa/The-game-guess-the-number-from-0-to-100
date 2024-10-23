using System;

class GuessNumberGame
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(0, 101); // Случайное число от 0 до 100
        int userGuess = -1; // Переменная для хранения предположения пользователя
        int attempts = 0;   // Счетчик попыток

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Компьютер загадал число от 0 до 100. Попробуйте его угадать.");

        // Цикл, продолжающийся до тех пор, пока пользователь не угадает число
        while (userGuess != targetNumber)
        {
            attempts++; // Увеличиваем счетчик попыток

            Console.Write("Введите ваше предположение: ");
            // Проверяем, что пользователь ввел корректное число
            if (int.TryParse(Console.ReadLine(), out userGuess))
            {
                if (userGuess < 0 || userGuess > 100)
                {
                    Console.WriteLine("Пожалуйста, введите число в диапазоне от 0 до 100.");
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else if (userGuess < targetNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine($"Поздравляю! Вы угадали число за {attempts} попыток.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное целое число.");
            }
        }
    }
}