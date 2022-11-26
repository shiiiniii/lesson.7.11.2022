//Задача 69: Напишите программу, которая на вход 
//принимает два числа A и B, и возводит число 
//А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8


Console.Clear();
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень в которую будете возводить натуральное число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Exponation(int numA, int numB)
{
    if(numB == 0) return 1;
    return numA * Exponation(numA, numB - 1);
}
while(numB < 0) 
{
    Console.WriteLine($"Введено отрицательное число.");
    Console.WriteLine($"Введите натуральное число степени: ");
    numB = Convert.ToInt32(Console.ReadLine());
}

    int exponation = Exponation(numA, numB);
    Console.WriteLine($"Число {numA} в {numB} степени = {exponation}");

