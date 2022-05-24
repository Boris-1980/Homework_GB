// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// (с помощью рекурии)
//  453 -> 12
//  45 -> 9

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int RecursionSum(int a)
{
    if (a < 1) return 0;
    return RecursionSum(a / 10) + a % 10;
}

Console.WriteLine($"Сумма числа {a} равна {RecursionSum(a)}");
