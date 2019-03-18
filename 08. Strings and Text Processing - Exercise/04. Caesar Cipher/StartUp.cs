using System;

class StartUp
{
    public static void Main()
    {
        char[] text = Console.ReadLine().ToCharArray();

        for (int i = 0; i < text.Length; i++)
        {
            text[i] = (char)((int)text[i] + 3);
        }
        Console.WriteLine(string.Join("", text));
    }
}