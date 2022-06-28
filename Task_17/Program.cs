
// Задача 17.  Напишите программу, которая принимает на вход координтаы точки (  X и Y ) причем  X и Y  не равны 0 
// и выдает номер четверти плосткости в которой находится эта тоска.


Console.WriteLine("Введите  координтаты точки   X и Y");
Console.Write("X =");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y =");
int y = Convert.ToInt32(Console.ReadLine());

// if ( x > 0 && y > 0)
// {
//  Console.WriteLine("Первая четверть");   
// }
// else if ( x < 0 && y > 0)
// {
//  Console.WriteLine("Вторая четверть");     
// }
// else if ( x < 0 && y < 0)
// {
//  Console.WriteLine("Третья четверть");   
// }

// else if ( x > 0 && y < 0)
// {
//  Console.WriteLine("Четверта четверть");  
// }
// else Console.WriteLine("ВВедены не корректные данные");


string Quard(int xc, int yc)
{
if ( xc > 0 && yc > 0)  return "Первая четверть";
if ( xc < 0 && yc > 0) return "Вторая четверть)";
if ( xc < 0 && yc < 0)  return "Третья четверть";
if ( xc > 0 && yc < 0) return "Четвертая четверть";  
return "Введены не корректные данные";
}
string result = Quard(x, y);
Console.WriteLine(result);