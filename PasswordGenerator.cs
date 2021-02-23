using System;
using System.Text;

// Prompt the user if they would like to have a pswd generated for them,
// the pswd will be a random combination of 5 characters
public class PasswordGenerator
{

    char letter;
    // Entry point to the program
    static void Main()
    {
        PasswordGenerator pswd = new PasswordGenerator();
        pswd.formatMenu();
    }


    public void formatMenu()
    {
        Console.WriteLine(("").PadRight(60, '-'));
        Console.WriteLine("\nThis program generates a password consisting of five random characters.\n");
        Console.WriteLine("Your random password is: " + generatePassword());
        Console.WriteLine(("").PadRight(60, '-'));
    }

    public string generatePassword()
    {
        // Generate new random
        Random r = new Random();
        // Length of the password
        int length = 5;
        // Initailly set it to an empty string
        var password = "";
        // Loop through and generate 5 random characters
        for(var i = 0; i < length; i++)
        {
            // Append each new character, one after the other
            password += ((char)(r.Next(1, 26) + 65)).ToString().ToUpper();
        }

        // Return the generated password
        return password;
    }


    public string buildPassword()
    {
        // the length for the password
        int length = 5;
        // Build a new generator
        Random r = new Random();
        // Generates a string builder
        StringBuilder strBuild = new StringBuilder();

        // Loop that will go 'length' amount of times and generate
        // a random string
        for (int i = 0; i < length; i++)
        {
            double num = r.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * num));
            letter = Convert.ToChar(shift + 65);
            strBuild.Append(letter);
        }

        return letter.ToString();
    }
}
