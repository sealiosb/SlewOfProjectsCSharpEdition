namespace slewOfProjects;

public class MainMenu
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Slew Of Projects");
        Console.WriteLine("This is a collection of small projects.");
        Console.WriteLine("Please select a project to run:");
        Console.WriteLine("1. RN Guessing Game");
        Console.WriteLine("2. Banking App Backend");
        Console.WriteLine("3. First Unique Character in String");
        Console.WriteLine("4. Longest Consecutive Sequence in Number Array");
        Console.WriteLine("5. Anagram Sorter");
        Console.WriteLine("Enter the number of your choice:");
        
        
        string Choice = Console.ReadLine();
        
        if (int.TryParse(Choice, out int index))
        {
            switch (index)
            {
                case 1:
                    RNGuessingGame.Run();
                    break;
                case 2:
                    BankingAppMain.Run();
                    break;
                case 3:
                    FirstUniqueCharacter.Run();
                    break;
                case 4:
                    LongestConsecutiveSequence.Run();
                    break;
                case 5:
                    AnagramSorter.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid project number.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}