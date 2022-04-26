// Напишите программу, которая задаёт массив из некоторого 
// количества элементов и выводит их на экран с помощью функций. 
// (можно спрашивать количество вводимых элементов и вводить все значения с клавиатуры)

Console.WriteLine("Введите количество элементов массива:  ");
int element = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[element];
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i} - ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вывод массива: ");
for (int i = 0; i < Array.Length; i++)
{
    Console.WriteLine(Array[i]);
}