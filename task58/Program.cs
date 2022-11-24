//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Clear();
Console.Write("Программа будет находить произведение двух матриц");
Console.WriteLine();
Console.Write("Введите количество строк 1 матрицы: ");
int rowsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1 матрицы: ");
int columnsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2 матрицы: ");
int rowsB = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2 матрицы: ");
int columnsB = int.Parse(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

int [,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return result;
}

int[,] firstMatrix = CreateMatrixRndInt(rowsA, columnsA, 0, 10);
int[,] secondMatrix = CreateMatrixRndInt(rowsB, columnsB, 0, 10);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц равно:");
int[,] result = MatrixMultiplication(firstMatrix, secondMatrix);
PrintMatrix(result);