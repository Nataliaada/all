
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
void GetQub (int a)
{
int index = 1;
int result = a*a*a;
while ( index <= a)
{
int qub = index * index * index;
Console.WriteLine($" Куб числа {index} | {qub, 3}|");
index ++;
}
}
GetQub(num);
