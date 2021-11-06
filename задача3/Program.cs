// Даны два числа. Показать большее и меньшее число
int a = 4;
int b = 6;
int max = 0;
int min = 0;
if (a>b)
{
    max=a;min=b;
}
else
{
    max=b;min=a;
}
Console.WriteLine(max);Console.WriteLine("^ максимальное число");
Console.WriteLine(min);Console.WriteLine("^ минимальное число");
//финиш
