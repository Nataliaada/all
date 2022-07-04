
// Задача 26: Напишите программу, которая принимает  на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (num != 0) //Не равно
{
    num = num / 10; // num /=;
    count = count + 1; // count++;
}
Console.WriteLine($" Количество символов в массиве =  {count}");
