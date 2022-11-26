// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

 
Console.Clear();
Console.Write("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int FindSum(int m, int n)
{
    if (m == n) return n;
    return n + FindSum(m, n - 1);
}

while(m < 0) 
{
    Console.WriteLine($"Вы ввели первое число отрицательным.");
    Console.WriteLine($"Введите натуральное число: ");
    m = Convert.ToInt32(Console.ReadLine());
}

while(n < 0) 
{
    Console.WriteLine($"Вы ввели второе число отрицательным.");
    Console.WriteLine($"Введите натуральное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {FindSum(m, n)}");
 
