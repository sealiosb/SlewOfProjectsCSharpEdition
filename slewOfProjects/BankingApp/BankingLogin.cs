namespace slewOfProjects;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class BankingLogin
{
    public static void reSerialiseLoginData(string fileName, List<BankingLoginDataClass> logins)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string newJson = JsonSerializer.Serialize(logins, options);
        Console.WriteLine("Data written to: " + Path.GetFullPath(fileName));
        File.WriteAllText(fileName, newJson);
        Console.WriteLine("Login data saved successfully.");
    }
    
    public static bool Login()
    {
        Console.WriteLine("Please enter your account number:");
            
        string fileName = "BankingLogin.json";
        List<BankingLoginDataClass> logins = new();

        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            logins = JsonSerializer.Deserialize<List<BankingLoginDataClass>>(json) ?? new List<BankingLoginDataClass>();
            Console.WriteLine(logins.Count);
        }
            
        string AccountNumberLogin = Console.ReadLine();
        while (AccountNumberLogin == null)
        {
            Console.WriteLine("Account number not found. Please try again.");
            AccountNumberLogin = Console.ReadLine();
        }
        while (!int.TryParse(AccountNumberLogin, out _))
        {
            Console.WriteLine("Invalid account number format. Please enter a valid number.");
            AccountNumberLogin = Console.ReadLine();
            
        }
            
        int accountNumberParsed = Int32.Parse(AccountNumberLogin);
        var user = logins.FirstOrDefault(l => l.AccountNumber == accountNumberParsed);
        Console.WriteLine("Please enter your password:");
        string inputPassword = Console.ReadLine();

        while (inputPassword == null)
        {
            Console.WriteLine("Please enter your password.");
            inputPassword = Console.ReadLine();
        }
        Console.WriteLine("Working on it...");
            
        var userLogin = logins.FirstOrDefault(l => l.AccountNumber == accountNumberParsed && l.Password == inputPassword);

        if (user == null)
        {
            Console.WriteLine("Account not found. Please try again.");
            Login();
        }
            
        reSerialiseLoginData(fileName, logins);
        Console.WriteLine($"Welcome back {user.FirstName} {user.LastName}!");
        Console.WriteLine($"Your account number is {user.AccountNumber} and your balance is {user.Balance}.");
        bool isLoggedIn = true;
        return isLoggedIn;
    }
}