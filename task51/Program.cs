// Задача 51: Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на 
//главной диагонали (с индексами
//(0,0); (1;1) и т.д.


Console.Clear();


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        for (int i = 0; i < matrix.GetLength(0); i++) 
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
            else Console.Write($"{matrix[i, j], 5}");
            }
            Console.WriteLine(" |");
            }
}

int SumMatrixCrossLine(int[,] matrix)
{
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        
        for (int j = 0; j < matrix.GetLength(0); j++) 
        {
            if(i == j)
            {
                sum = matrix[i, j] + sum;
            }
        }  
    }
    return sum;
}


int[,] array2D = CreateMatrixRndInt(3, 6, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
int sumMatrixCrossLine = SumMatrixCrossLine(array2D);
Console.WriteLine(sumMatrixCrossLine);
