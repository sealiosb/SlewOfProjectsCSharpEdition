namespace slewOfProjects;

using System;
using System.Collections.Generic;
using System.Linq;

class AnagramSorter
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            var chars = word.ToCharArray();
            Array.Sort(chars);
            var key = new string(chars);

            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }

            map[key].Add(word);
        }

        return map.Values.ToList<IList<string>>();
    }

    public static void Run()
    {
        string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };
        Console.WriteLine("Current list of words:");
        foreach (var word in input)
        {
            Console.WriteLine($"{word}");
        }
        
        Console.WriteLine("Would you like to add to the list? (yes/no)");
        
        string choice = Console.ReadLine()?.ToLower() ?? "no";
        
        while (choice == "yes")
        {
            Console.WriteLine("Enter a word to add:");
            string newWord = Console.ReadLine()?.Trim() ?? string.Empty;
            if (!string.IsNullOrEmpty(newWord))
            {
                input = input.Append(newWord).ToArray();
                
                
                Console.WriteLine($"Added '{newWord}' to the list.");
                Console.WriteLine("Would you like to add another word? (yes/no)");
                
                
                choice = Console.ReadLine()?.ToLower() ?? "no";
            }
            else
            {
                Console.WriteLine("No word added.");
            }
        }
        
        var result = GroupAnagrams(input);

        foreach (var group in result)
        {
            Console.WriteLine("[" + string.Join(", ", group) + "]");
        }
    }
}
