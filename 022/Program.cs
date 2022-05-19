// Задать двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце:

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}

string Arithmetic(int[,] array)
{
    string result = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        int count = 0;
        double arth = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
            count++;
        }
        arth = sum / count;
        result += arth.ToString() + "\t";
    }
    return result;
    
}

int m = 3;
int n = 5;
int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine(Arithmetic(array));
