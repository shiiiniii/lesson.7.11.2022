// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Например, задан массив размером 2 x 2 x 2.
//Результат:
//66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
//34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


Console.Clear();
Console.Write("Трёхмерный массив из неповторяющихся двузначных чисел с добавлением индекса каждого элемента.");
Console.WriteLine();
Console.Write("Введите размер трехмерного массива m x n x p: ");
Console.WriteLine();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите p: ");
int p = Convert.ToInt32(Console.ReadLine());

bool FindNonRepeatingElement(int[,,] array, int elem) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == elem) return true;
            }
        }
    }
    return false;
}

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            int k = 0;
            while (k < matrix.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindNonRepeatingElement(matrix, element)) continue;
                matrix[i, j, k] = element;
                k++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})");   
            }
        }
    Console.WriteLine(" ]");
    }
}


int[,,] newMatrixRndInt = CreateMatrixRndInt(m, n, p, 10, 100);
Console.WriteLine();
PrintMatrix(newMatrixRndInt);