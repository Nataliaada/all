
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Введите  координтаты точки  X1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  координтаты точки Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  координтаты точки Z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  координтаты точки X2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  координтаты точки  Y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  координтаты точки Z2");
int z2 = Convert.ToInt32(Console.ReadLine());
double Distance(int a1, int b1, int z1, int a2, int b2, int z2)
{
    double res = Math.Sqrt((a2-a1) *(a2 -a1) + (b2- b1)*(b2- b1)+(z2- z1)*(z2- z1));
    res = Math.Round(res, 2);
    return res;
}

double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);