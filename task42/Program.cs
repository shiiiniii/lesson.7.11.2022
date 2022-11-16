//Задача 42: Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное.
//45 -> 101101 45 % 2; res * 10; + остаток
//3 -> 11
//2 -> 10

Console.Clear();
Console.WriteLine(" Введите число в десятичной системе");
int number = Convert.ToInt32(Console.ReadLine());

int Binare(int num)
{
string st = "";
while (num > 0)
{
string temp = Convert.ToString(num % 2);
st = temp + st;
num = num / 2;
}

int bin = Convert.ToInt32(st);
return bin;
}
Console.WriteLine($"Число {number} в двоичной системе выглядит {Binare(number)}");