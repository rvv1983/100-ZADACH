// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
 char GetMaxNumber(int num) 
{ 
    string ab = Convert.ToString(num); 
    char a = ab[0]; 
    char b = ab[1]; 
    if (a > b) return a; 
    else return b; 
} 
int num = new Random().Next(10, 100); 
char result = GetMaxNumber(num); 
Console.WriteLine($"В числе {num} наибольшая цифра - {result}");
//готов!
