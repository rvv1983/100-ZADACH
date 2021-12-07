// Задать массив из 12 элементов, заполненных числами от 0 до 9. Найти сумму положительных и отрицательных элементов массива

int[] a = new int[12];
int s1 = 0;
int s2 = 0;
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(0, 10);
    Console.Write(a[i] + " ");
    if (a[i] > 0)
    {
        s1 = s1 + a[i];
    }
    else
    {
        s2 = s2 + a[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = " + s1);
Console.WriteLine($"Сумма отрицательных чисел = " + s2);