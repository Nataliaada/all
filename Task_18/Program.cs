// Задача 18. Напишите программу, которая принимает номер четверти, и покаывает диапазоны  возможных координат


Console.WriteLine("Введите   номер четверти");
int num = Convert.ToInt32(Console.ReadLine());
string result;
string Coordinate (int a)
{
string res = "";
if (a == 1) res = " x > 0 И y > 0 ";
if (a == 2) res = " x < 0 И y > 0 ";
if (a == 3) res  = " x < 0 И y < 0 ";
if (a == 4) res = " x > 0 И y < 0 ";  
return res;
}

if ( num> 0 && num < 5)
{
    result = Coordinate(num);
}
else 
{
    result = "ВВедены не корректные данные";
}
Console.WriteLine(result);