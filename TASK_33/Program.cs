// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());


int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 200);
        index++;
    }
    return array;
}

void FindNumer(int [] array1, int num1)
{ 
    string res = "Нет";
    for (int i = 0; i < array1.Length; i++)
    {
    if (array1[i] == num1)  
    res = "Да";
    } 
    Console.WriteLine();
    Console.WriteLine(res);
}
void PrintArray(int[] array1)
{
 for (int i = 0; i < array1.Length; i++)
    {
    if (i == 0) Console.Write("[");
    if (i<array1.Length - 1) Console.Write(array1[i] + " , ");
    else Console.Write(array1[i] + " ] ");
    }
}

int[] array = CreateArrayRndInt(7);
PrintArray(array);
FindNumer(array, num);


