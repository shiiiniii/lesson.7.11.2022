// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Программа вычисления функции Аккермана");
Console.WriteLine();
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
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

int akkermanFunction = AkkermanFunction(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");