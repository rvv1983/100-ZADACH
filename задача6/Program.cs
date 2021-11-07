// Написать программу вычисления значения функции y=f(a) 

   class Program
   {
      static void Main(string[] args)
      {
         Console.Write("Вычисление sin(x)\nУгол в градусах = ");
         double a = Convert.ToDouble(Console.ReadLine());
         double x, y;
         x = a * Math.PI / 180;
         y = Math.Sin(x);
         Console.WriteLine("sin({0})={1}",x,y);
         Console.ReadKey();
      }
   }