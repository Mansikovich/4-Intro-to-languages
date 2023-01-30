using System;

namespace ConsoleApp
{
class Program
{
static void Main()

{
Console.Write("Введи числа через запятую ");
string number = Console.ReadLine();
Console.WriteLine(Array(number));

}

public static string Array(string number)

{
number = $"[{number}]";    
 return number;      
}
}

}