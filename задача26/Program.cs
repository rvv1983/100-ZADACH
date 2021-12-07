// 26. Возведите число А в натуральную степень B используя цикл

int a = 2;
int b = 10;
for (int i = 1; i<=b; i++)
{
    Console.WriteLine($"Число {a} в {i}й степени = {Math.Pow(a,i)}");
}