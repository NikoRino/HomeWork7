// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintNumber(int[,] massive, int a, int b, int m, int n)
{
    if (a > m || b > n)
        Console.WriteLine("Tакого числа нет");
    else
    {
        object c = massive.GetValue(a, b);
        Console.WriteLine(c);
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
int a = GetInput("Введите координаты строки массива: ");
int b = GetInput("Введите координаты строк массива: ");
PrintNumber(massive, a, b, m, n);