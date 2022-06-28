//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет 12821 -> да 23432 -> да
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

void Palindrom(int a)
{
if (a > 9999 && a < 100000)
{
int res1 = a / 10000;
int res2 = a / 1000 % 10;
int res3 = a / 10 % 10;
int res4 = a % 10;
if (res1==res4 && res2==res3) Console.WriteLine("да");
else Console.WriteLine("Нет");
}
else Console.WriteLine("Введено неверное число");
}
Palindrom(num);
