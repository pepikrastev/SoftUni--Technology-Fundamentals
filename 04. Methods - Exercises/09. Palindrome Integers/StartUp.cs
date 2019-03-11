namespace _09._Palindrome_Integers
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string reversedWord = string.Empty;

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversedWord += command[i];
                }

                bool isPalindron = IsPalindron(command, reversedWord);

                Console.WriteLine(isPalindron == true ? "true" : "false");
            }
        }

        private static bool IsPalindron(string word, string reversedWord)
        {
            return word == reversedWord;
        }
    }
}
