// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

int size = new Random().Next(5, 10);

Console.WriteLine($" Элементов в  массиве: {size}");

double[] Array(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void MinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double diff = arr.Max() - arr.Min();
    Console.WriteLine($" Минимальное значение =   {arr.Min()}");
    Console.WriteLine($" Максимальное значение =  {arr.Max()}");
    Console.WriteLine();
    Console.WriteLine($" Разница между значениями  {diff}");
    
}

MinMax(Array(size));
Console.WriteLine();