namespace _08._Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "3:1")
                {
                    break;
                }

                string[] tokens = input.Split();

                string comand = tokens[0];

                if (comand == "merge")
                {
                    int statrIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (statrIndex < 0)
                    {
                        statrIndex = 0;
                    }
                    if (statrIndex > words.Count - 1 || endIndex < 0)
                    {
                        continue;
                    }
                    if (endIndex > words.Count - 1)
                    {
                        endIndex = words.Count - 1;
                    }

                    Merge(words, statrIndex, endIndex);
                }
                else
                {
                    int indexOFWord = int.Parse(tokens[1]);
                    int parts = int.Parse(tokens[2]);

                    string element = words[indexOFWord];

                    words.RemoveAt(indexOFWord);

                    List<string> newWords = Divide(element, parts);

                    words.InsertRange(indexOFWord, newWords);
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }

        private static List<string> Divide(string element, int parts)
        {
            List<string> newWords = new List<string>();
            int partLenght = element.Length / parts;
            int lastPartLenght = partLenght + element.Length % parts;

            for (int i = 0; i < parts; i++)
            {
                string newWord = element.Substring(i * partLenght, partLenght);
                if (i == parts - 1)
                {
                    newWord = element.Substring(i * partLenght, lastPartLenght);
                }
                newWords.Add(newWord);
            }
            return newWords;
        }

        private static void Merge(List<string> words, int statrIndex, int endIndex)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = statrIndex; i <= endIndex; i++)
            {
                string word = words[i];
                sb.Append(word);
            }

            words.RemoveRange(statrIndex, endIndex - statrIndex + 1);
            words.Insert(statrIndex, sb.ToString());
        }
    }
}
