//Определить количество цифр в числе

int CountCheck(int n)
{
    int s=0;

    while (n!=0)
    {
        s++;
        n=n/10;
    }

    return s;
}

Console.WriteLine(CountCheck(125566));