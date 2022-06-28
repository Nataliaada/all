// Задача 21. Напишите программму которая принимает на вход координаты 2 точек и находит расстояние между ниии в 2D  пространнстве


Console.WriteLine("Введите  координтаты точки  X1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  координтаты точки Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  координтаты точки X2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  координтаты точки  Y2");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int a1, int b1, int a2, int b2)
{
    double res = Math.Sqrt((a1 -a2) *(a1 -a2) + (b1- b2)*(b1- b2));
    res = Math.Round(res, 2);
    return res;
}

double result = Distance(x1, y1, x2, y2);
Console.WriteLine(result);