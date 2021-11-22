//19.  Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите 5 цифр:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(pol(a));
string pol(int a)
{
    string b = Convert.ToString(a);
    string res = $"Число {a} НЕ является палиндромом";
    if (b[0] == b[4] && b[1] == b[3]) res = $"Число {a} является палиндромом";
    return res;
}

