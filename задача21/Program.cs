// 21. Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Ввведите пятизначное число:");
string s = Console.ReadLine();
int a, b, c, d, e;
a = Convert.ToInt32(s);
b = a % 10;
c = a/10%10;
d = a/1000%10;
e = a/10000%10;
if(b==e&&c==d)
{
   Console.WriteLine("Данное число является полиндромом");
}
else
{
   Console.WriteLine("Данное число  не является полиндромом");
}
 

