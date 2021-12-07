// Показать кубы чисел, заканчивающихся на четную цифру
void ChisloVkube(int any)
{
    for(int i=1; i <=any; i++)
    {
        if(i*i*i%2==0)
        Console.WriteLine($"Куб числа {i} = {i*i*i}");
    }

}
Console.WriteLine("Введите число *any*, кубы чисел которого будут заканчиваться на четную цифру ");
int any = Convert.ToInt32(Console.ReadLine());

ChisloVkube(any);