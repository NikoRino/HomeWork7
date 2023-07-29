// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void SumMassive(int[,] massive)
{
    Console.WriteLine("Сумма по столбцам");
    double sum = 0;

    for (int i = 0; i < massive.GetLength(1); i++)
    {
        for (int j = 0; j < massive.GetLength(0); j++)
        {
            sum = sum + massive[j, i];
        }
        Console.Write($"{Math.Round(sum / massive.GetLength(0), 1)}\t");
        sum = 0;
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Print2Dmassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue);
        }

    }
    return matrix;
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int[,] massive = Create2DMassive(m, n, -99, 99);
Print2Dmassive(massive);
SumMassive(massive);
