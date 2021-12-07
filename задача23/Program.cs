// 23. Показать таблицу квадратов чисел от 1 до N 
int i =1;
Console.Write("Введите N: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"чмсла в квадрате диапазона от 1 до {a} равны следующим значениям");

while (i<=a)
{
     Console.Write(Math.Pow(i,2)+"  ");
     i++;
}