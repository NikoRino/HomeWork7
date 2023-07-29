// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Print2Dmassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue * 100, finishValue * 100);
            matrix[i, j] = matrix[i, j] / 100;
        }

    }
    return matrix;
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
double[,] massive = Create2DMassive(m, n, 1, 10);
Print2Dmassive(massive);
