using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {

            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Power(a,b));

            
            

        }
        public static double Power(double a, double b)
            {
                return  Math.Pow(a, b);
                
                
            }

    }
}
