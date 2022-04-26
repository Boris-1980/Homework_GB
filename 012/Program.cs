// Напишите (функцию) цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result =a;
 while (count < b)
{
    result = result * a;
    count++;
}

Console.Write($"Если число {a} возвести в степень {b} получим {result}");
