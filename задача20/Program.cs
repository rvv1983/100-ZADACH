// Ввести номер четверти, показать диапазоны для возможных координат
string Diapazon (int Chetvertina)
{
    string result = string.Empty;
    if (Chetvertina == 1) result = "X = (0, +vozmozhnosti); Y = [0, +vozmozhnosti)";
    if (Chetvertina == 2) result = "X = (-vozmozhnosti,0); Y = (0, +vozmozhnosti)";
    if (Chetvertina == 3) result = "X = (-vozmozhnosti,0); Y = (-vozmozhnosti,0)";
    if (Chetvertina == 4) result = "X = (0, +vozmozhnosti); Y = (-vozmozhnosti,0)";
    return result;
}
Console.WriteLine("Kakaya Chetvertina's # (1-4)");
int Chetvertina = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Diapazon(Chetvertina));