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
        Console.WriteLine("Enter the number of your choice:");
        
        
        string Choice = Console.ReadLine();
        
        if(int.TryParse(Choice, out int index))
        {
            if (index == 1)
            {
                RNGuessingGame.Run();
            }
            else if (index == 2)
            {
                BankingAppMain.Run();
            }
            else if (index == 3)
            {
                FirstUniqueCharacter.Run();
            }
            else if (index == 4)
            {
                LongestConsecutiveSequence.Run();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid project number.");
            }
                
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}