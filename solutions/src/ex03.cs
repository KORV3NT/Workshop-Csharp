/*
** EPITECH PROJECT, 2024
** workshop_csharp
** File description:
** ex03
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter name {0}: ", i + 1);
            string name = Console.ReadLine();
            names.Add(name);
        }

        Console.WriteLine("\nNames:");
        foreach (string name in names)
        {
            Console.WriteLine("{0}", name);
        }
    }
}
