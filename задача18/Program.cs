﻿//18. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("координата Х =  ");
double X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("координата  Y =  ");
double Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четверть Z: " + F(X, Y));
int F(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return -1;
}