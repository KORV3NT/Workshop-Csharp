using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "../Workshop-Csharp/bonus/words.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] words = File.ReadAllText(filePath).Split(' ');
            int totalWords = words.Length;
            var wordFrequency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                    wordFrequency[word]++;
                else
                    wordFrequency[word] = 1;
            }

            int uniqueWords = wordFrequency.Count;

            Console.WriteLine($"Total number of words: {totalWords}");
            Console.WriteLine($"Number of unique words: {uniqueWords}");
            Console.WriteLine("Word frequency:");

            foreach (var entry in wordFrequency)
            {
                Console.WriteLine($"- {entry.Key}: {entry.Value}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
