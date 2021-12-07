//  Написать программу вычисления произведения чисел от 1 до N

int MNOZH(int a)
{
    int s = 1;
    for (int i = 1; i <= a; i++)
    {
        s = s * i;
    }
    return s;
}
Console.Write("Введите край диапазона N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение всех чисел от 1 до {N} = {MNOZH(N)}");