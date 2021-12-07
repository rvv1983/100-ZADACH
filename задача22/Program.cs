// Решение от преподавателя
double Distance2D (double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));
}

Console.WriteLine(Distance2D(10, 28, 2, 14));