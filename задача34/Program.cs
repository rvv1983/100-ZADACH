// Написать программу замену элементов массива на противоположные  
int[] array = new int[2];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)

{
    array[i] = rnd.Next();

    Console.WriteLine(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)

{
    array[i] = array[i] * -1;

    Console.WriteLine(array[i]);
}