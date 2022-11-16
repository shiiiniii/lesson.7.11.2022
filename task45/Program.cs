// Задача 45: Напишите программу, которая будет 
//создавать копию заданного массива с помощью 
//поэлементного копирования.

Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(5, 10, 50);
PrintArray(arr);
int[] arrNew = CopyArray(arr);
arrNew[2] = 100; // это чтобы понять копию ли мы создали, просто число с индексом 2 будет всегда равно 100
PrintArray(arrNew);