namespace slewOfProjects;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

// This class serves as the main entry point for the Banking App, allowing users to create an account or log in.
// Whilst this app is a simple console application, it can be expanded with more features such as account management, transaction history, etc.
// This is purely backend functionality, and does not include any UI elements.
// The app uses JSON for data storage, and the data is saved in a file called "BankingLogin.json".
// In other applications, this could be replaced with a database or other storage solution.


public class BankingAppMain
{
    public static void Run()
    {
        Console.WriteLine("Welcome to the Banking App!");
        Console.WriteLine("Are you a new user? (yes/no)");
        string response = Console.ReadLine()?.ToLower();
        if (response == "yes"){
            BankingAccountCreation.CreateAccount();
        
        }
        if (response == "no")
        {
            if (BankingLogin.Login() == true)
            {
                Console.WriteLine("What would you like to do today?");
                
            }
            else
            {
                Console.WriteLine("Login failed. Please try again.");
            }
            
        }
        
    }
}


    


