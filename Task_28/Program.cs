
// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Proizved (int a)
// {
//     int proizved1 = 1;
//  for (int i = 1; i <= a; i++)
 
//     {
//      proizved1 = i * proizved1;
//    }
//  return proizved1;
// }
//  int proizved = Proizved(number);
//  Console.WriteLine($"Произведение числе от 1 до {number} = {proizved}");



Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

int res = 1;
int start = 1;
while (start <= n )
{
    checked
    {
    res *= start;
    start++;
}
}
Console.WriteLine(res);