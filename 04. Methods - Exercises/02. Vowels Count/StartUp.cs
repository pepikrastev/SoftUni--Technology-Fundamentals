namespace _02._Vowels_Count
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            PrintSumOfVolew(text);
        }

        private static void PrintSumOfVolew(string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
