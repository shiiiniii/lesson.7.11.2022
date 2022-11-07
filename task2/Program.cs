//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int numDigit)
{
    numDigit = Math.Abs(numDigit);
    int count = 0;
    while (numDigit > 0)
    {
        numDigit = numDigit / 10;
        count++;
    }
    return count > 0 ? count : 1;
}
int sumDigit = SumDigit(num);
Console.WriteLine($"Количество цифр в числе = {sumDigit}");
