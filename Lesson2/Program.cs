// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

namespace Lesson2;


public class Program
{

    public static void Main(string[] args)  
    {
        Console.WriteLine("Введите год!");

        var string1 = Console.ReadLine();

        var value1 = int.Parse(string1);

        if (value1 % 4 == 0 && value1 % 100 != 0 || value1 % 400 == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}