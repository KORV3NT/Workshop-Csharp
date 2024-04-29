/*
** EPITECH PROJECT, 2024
** workshop_csharp
** File description:
** ex01
*/

using System;

class Program
{
    static void Main()
    {
        string a;
        string b;
        string result;

        Console.Write("input1: ");
        a = Console.ReadLine();
        Console.Write("input2: ");
        b = Console.ReadLine();

        result = a + b;

        Console.WriteLine("Length of a + b is : {0}", result.Length);
    }
}

