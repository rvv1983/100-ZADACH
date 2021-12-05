// Показать числа от -N до N 8. Показать четные числа от 1 до N
void met (int N)
{
int count = -N;
while (count<= N)
{
    Console.WriteLine(count);
     count++;
     
}
Console.WriteLine("четные от 1 до N это");
for (int i = 1; i < N + 1; i++) if (i % 2 == 0) { Console.Write((i) + " "); }
}
met(7);
