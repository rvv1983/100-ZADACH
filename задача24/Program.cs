// 24. Найти кубы чисел от 1 до N

Console.WriteLine("Введите диапазон N  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("куб каждого числа будет");

for (int i = 1; i <= a ; i++)
{
    Console.Write(Math.Pow(i,3)+"  ");
}