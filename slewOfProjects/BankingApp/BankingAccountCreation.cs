namespace slewOfProjects;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class BankingAccountCreation
{
    public static void CreateAccount()
    {
            Console.WriteLine("Account creation in progress...");
            Random accountNumber = new Random();
            int accountNum = accountNumber.Next(100000, 999999);

            Console.WriteLine($"Your account number is {accountNum} write this down and keep it safe.");
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            if (firstName == null)
            {
                Console.WriteLine("Please enter your first name.");
                return;
            }

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            if (lastName == null)
            {
                Console.WriteLine("Please enter your last name.");
                return;
            }

            string password = GeneratePassword(firstName, lastName);
            Console.WriteLine("To ensure your account is secure, we have generated a password for you.");
            Console.WriteLine($"Your password is {password} write this down and keep it safe.");

            var login = AccountCreation(firstName, lastName, accountNum, password);
            string fileName = "BankingLogin.json";
            SaveLogin(login, fileName);

        
    }

    public static string GeneratePassword(string firstName, string lastName)
    {
        Random random = new Random();
        int randomNumber = random.Next(1000, 9999);
        const string specialCharacters = "!@#$%^&*()_+";
        char randomSpecialCharacter = specialCharacters[random.Next(specialCharacters.Length)];
        string password = $"{firstName.ToUpper()}{lastName.ToLower()}{randomSpecialCharacter}{randomNumber}";
        return password;
    }

    public static BankingLoginDataClass AccountCreation(string firstName, string lastName, int accountNumber,
        string password)
    {
        var login = new BankingLoginDataClass
        {
            FirstName = firstName,
            LastName = lastName,
            AccountNumber = accountNumber,
            Password = password,
            Balance = 0
        };

        return login;
    }
    
    public static void SaveLogin(BankingLoginDataClass login, string fileName)
    {
        List<BankingLoginDataClass> logins;

        if (File.Exists(fileName))
        {
            string existingJson = File.ReadAllText(fileName);
            logins = JsonSerializer.Deserialize<List<BankingLoginDataClass>>(existingJson)
                     ?? new List<BankingLoginDataClass>();
        }
        else
        {
            logins = new List<BankingLoginDataClass>();
        }

        logins.Add(login);
        var options = new JsonSerializerOptions { WriteIndented = true };
        string newJson = JsonSerializer.Serialize(logins, options);
        Console.WriteLine("Data written to: " + Path.GetFullPath(fileName));
        File.WriteAllText(fileName, newJson);
        Console.WriteLine("Login data saved successfully.");
    }
    
}