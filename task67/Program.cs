//семинар//Задача 67: Напишите программу, которая будет 
//принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

Console.Clear();
Console.Write("Введите многозначное натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
   if(num == 0) return num;
   return num % 10 + SumNumbers(num / 10);   
}

int sumNumbers = SumNumbers(number);
Console.Write($"Сумма цифр вашего числа = {sumNumbers}");


