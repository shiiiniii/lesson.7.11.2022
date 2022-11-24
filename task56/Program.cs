// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2 
//5 9 2 3 
//8 4 2 4 
//5 2 6 7 
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой 
//элементов: 1 строка


Console.Clear();

Console.Write("Введите количество строк двумерного массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива : ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" |");
        }
    Console.WriteLine(" ]");
    }
}

int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}

void GetMinRowSum(int[,] matrix)
{
  int minSumLine = 0;
  int sumLine = SumLineElements(matrix, 0);
  for (int i = 1; i < matrix.GetLength(0); i++)
  {
    int tempSumLine = SumLineElements(matrix, i);
    if (sumLine > tempSumLine)
    {
      sumLine = tempSumLine;
      minSumLine = i;
    }
  }
  Console.Write($"Индекс строчки с наименьшкй суммой элементов = {minSumLine}");
}

int[,] newMatrixRndInt = CreateMatrixRndInt(m, n, 1, 10);
Console.WriteLine();
PrintMatrix(newMatrixRndInt);   
Console.WriteLine(); 
GetMinRowSum(newMatrixRndInt);