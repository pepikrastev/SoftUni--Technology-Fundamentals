namespace _03._Zig_Zag_Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int linseCount = int.Parse(Console.ReadLine());

            int[] firstArr = new int[linseCount];
            int[] secondArr = new int[linseCount];

            for (int i = 0; i < linseCount; i++)
            {
                int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = number[0];
                    secondArr[i] = number[1];
                }
                else
                {
                    firstArr[i] = number[1];
                    secondArr[i] = number[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));

            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}