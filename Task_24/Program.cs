
// Задача 24: Напишите программу, которая  принимает на вход число (А) и выдаёт сумму чисел  от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

// for (int i = 1; i <= number; i++)

// {
// sum = i + sum; // sum += i;
// if( i < number) Console.Write($"{i} + ");
// else Console.Write($"{i} = ");
// }
// Console.WriteLine(sum);

int Sum(int a)
{
    int sum1 = 0;
 for (int i = 1; i <= a; i++)
 
    {
     sum1 = i + sum1;
   }
 return sum1;
}
 sum = Sum(number);
 int sum2 = Sum(5);
 Console.WriteLine(sum2);
Console.WriteLine($"Сумма числе от 1 до {number} = {sum}");
