﻿// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

namespace Lesson2;


public class Program
{

    public static void Main(int.value1)
    {
        Console.WriteLine("Введите год!");

        var value1 = Console.ReadLine();

        if (value1%4 == 0, value1%400 == 0, value1%100 != 0)
        {
            Console.WriteLine("Год високостый!");
        }
        else
        {
            Console.WriteLine("Год не високосный");
        }
    }
}

