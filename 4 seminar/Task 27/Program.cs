using System;

namespace ConsoleApp
{
class Program
{
static void Main()

{
Console.Write("Введи пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(number));

}

public static int Sum(int n)

{
int sum = 0;
while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
 return sum;      
}
}

}


