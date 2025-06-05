// See https://aka.ms/new-console-template for more information

using slewOfProjects;

class RNGuessingGame
{
    public static void Run()
    {
        Console.WriteLine(
            @"▄▄▌ ▐ ▄▌▄▄▄ .▄▄▌   ▄▄·       • ▌ ▄ ·. ▄▄▄ .    ▄▄▄▄▄          ▄▄▄▄▄ ▄ .▄▄▄▄ .     ▄▄ • ▄• ▄▌▄▄▄ ..▄▄ · .▄▄ · ▪   ▐ ▄  ▄▄ •      ▄▄ •  ▄▄▄· • ▌ ▄ ·. ▄▄▄ .
██· █▌▐█▀▄.▀·██•  ▐█ ▌▪▪     ·██ ▐███▪▀▄.▀·    •██  ▪         •██  ██▪▐█▀▄.▀·    ▐█ ▀ ▪█▪██▌▀▄.▀·▐█ ▀. ▐█ ▀. ██ •█▌▐█▐█ ▀ ▪    ▐█ ▀ ▪▐█ ▀█ ·██ ▐███▪▀▄.▀·
██▪▐█▐▐▌▐▀▀▪▄██▪  ██ ▄▄ ▄█▀▄ ▐█ ▌▐▌▐█·▐▀▀▪▄     ▐█.▪ ▄█▀▄      ▐█.▪██▀▐█▐▀▀▪▄    ▄█ ▀█▄█▌▐█▌▐▀▀▪▄▄▀▀▀█▄▄▀▀▀█▄▐█·▐█▐▐▌▄█ ▀█▄    ▄█ ▀█▄▄█▀▀█ ▐█ ▌▐▌▐█·▐▀▀▪▄
▐█▌██▐█▌▐█▄▄▌▐█▌▐▌▐███▌▐█▌.▐▌██ ██▌▐█▌▐█▄▄▌     ▐█▌·▐█▌.▐▌     ▐█▌·██▌▐▀▐█▄▄▌    ▐█▄▪▐█▐█▄█▌▐█▄▄▌▐█▄▪▐█▐█▄▪▐█▐█▌██▐█▌▐█▄▪▐█    ▐█▄▪▐█▐█ ▪▐▌██ ██▌▐█▌▐█▄▄▌
 ▀▀▀▀ ▀▪ ▀▀▀ .▀▀▀ ·▀▀▀  ▀█▄▀▪▀▀  █▪▀▀▀ ▀▀▀      ▀▀▀  ▀█▄▀▪     ▀▀▀ ▀▀▀ · ▀▀▀     ·▀▀▀▀  ▀▀▀  ▀▀▀  ▀▀▀▀  ▀▀▀▀ ▀▀▀▀▀ █▪·▀▀▀▀     ·▀▀▀▀  ▀  ▀ ▀▀  █▪▀▀▀ ▀▀▀ ");
        Console.WriteLine("I have created a number between 1 and 100. Can you guess it?");
        Console.WriteLine("Enter your guess: ");
        
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int numberOfTries = 0;
        int guess = 0;
        
        while (guess != numberToGuess)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out guess))
            {
                numberOfTries++;
                if (guess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (guess == numberToGuess)
                {
                    Console.WriteLine($"Congratulations! You guessed the number {numberToGuess} in {numberOfTries} tries.");
                    Console.WriteLine("Would you like to play again? (yes/no)");
                    if (Console.ReadLine() == "yes")
                    {
                        Run();
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        
    }
}
