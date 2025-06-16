namespace slewOfProjects;

using slewOfProjects;

class FirstUniqueCharacter
{
    public static void Run()
    {
        Console.WriteLine("Enter a string to find the first unique character:");
        string input = Console.ReadLine()?.ToLower() ?? string.Empty;

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }

        foreach (char c in input)
        {
            if (input.Count(x => x == c) == 1)
            {
                Console.WriteLine($"The first unique character is: {c}");
                return;
            }
        }
        Console.WriteLine("No unique character found.");
    }
}