using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        string[] userNames = Console.ReadLine()
            .Split(", ");

        List<string> valideUsername = new List<string>();

        for (int i = 0; i < userNames.Length; i++)
        {
            string userName = userNames[i];

            if (userName.Length >= 3 && userName.Length <= 16)
            {
                bool validateContent = ValidateUsernameContent(userName);

                if (validateContent) 
                {
                    valideUsername.Add(userName);
                }
            }
        }
        Console.WriteLine(string.Join(Environment.NewLine, valideUsername));
    }

    private static bool ValidateUsernameContent(string username)
    {
        foreach (var symbol in username)
        {
            if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
            {
                continue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}