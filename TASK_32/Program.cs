// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


void printRndMassive(int [] arr)
{
int index = 0 ;
var rnd = new Random();

while (index < arr.Length)
{
    arr[index] = rnd.Next(-9, 10);
    Console.Write($" {arr[index]} ");
    arr[index] = -arr[index];
  index++;
}
for ( int i  = 0; i < arr.Length; i ++)
{
    if (i == 0) Console.Write("[");
    if (i < arr.Length -1) Console.Write(arr[i] + ", ");
    else Console.Write(arr[i]+"]");
}
}
int [] array = new int [8];
printRndMassive(array);


