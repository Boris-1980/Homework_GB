// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Какое количество чисел хотите ввести:  ");
int numbers = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < numbers; i++)
{
    Console.WriteLine($"Введите {i + 1} число ");
    if (Convert.ToInt32(Console.ReadLine()) > 0) count++;
}

Console.WriteLine($"Количество чисел больше нуля равно {count} ");
