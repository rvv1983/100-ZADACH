// 28. Подсчитать сумму цифр в числе

int a = new Random().Next(0, 1000);
Console.WriteLine(a);

int Sum(int s)
{
    int summ = 0;
    while (s != 0)
    {
        summ = summ + s % 10;
        s = s / 10;
    }
    return summ;
}
Console.WriteLine($"Сумма введенных цифр  {a} = {Sum(a)}");
