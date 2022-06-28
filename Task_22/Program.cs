//Задача 22 Напишите программу которая принимает на вход числ Н и выдает таблицу квадратов чисел от 1 до Н

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
void GetQuad (int a)
{
int index = 1;
int result = a*a;
while ( index <= a)
{
int Quad = index * index;
Console.WriteLine($" Квадрат числа {index} | {Quad, 5}|");
index ++;
}
}
GetQuad(num);


// for (int i = 1 ; i < a;  i++)
// {  
// Console.WriteLine($"Квадрат числа  {i} | {i*i, 2}|");  
// }