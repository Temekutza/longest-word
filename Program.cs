using System;
using System.Collections.Generic;

namespace StringParser
{
    /*class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char chr = Console.ReadLine()[0];

            bool isInsideWord = false;
            int wordStartIndex = 0;
            int maxWordLength = 0;

            List<string> strings = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!isInsideWord && (i == 0 || str[i - 1] == ' ') && str[i] == chr)
                {
                    // начало нового слова, начинающегося на букву
                    isInsideWord = true;
                    wordStartIndex = i;
                }

                if (isInsideWord && (str[i] == ' ' || i == str.Length - 1))
                {
                    // слово закончилось
                    isInsideWord = false;
                    int currentLength = i - wordStartIndex;

                    if (currentLength > maxWordLength)
                    {
                        maxWordLength = currentLength;
                        strings.Clear();
                        strings.Add(str.Substring(wordStartIndex, currentLength));
                    }
                    else if (currentLength == maxWordLength)
                        strings.Add(str.Substring(wordStartIndex, currentLength));
                }
            }

            foreach (string str2 in strings)
                Console.WriteLine(str2);
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char chr = Console.ReadLine()[0];

            bool isInsideWord = false;
            int wordStartIndex = 0;
            int maxWordStartIndex = 0;
            int maxWordLength = 0;

            string temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!isInsideWord && (i == 0 || str[i - 1] == ' ') && str[i] == chr)
                {
                    // начало нового слова, начинающегося на букву
                    isInsideWord = true;
                    wordStartIndex = i;
                    temp = "";
                }

                if (isInsideWord && str[i] != ' ')
                    temp += str[i];

                if (isInsideWord && (str[i] == ' ' || i == str.Length - 1))
                {
                    // слово закончилось
                    isInsideWord = false;
                    int currentLength = i - wordStartIndex;

                    if (currentLength >= maxWordLength)
                    {
                        maxWordStartIndex = wordStartIndex;
                        maxWordLength = currentLength;
                    }
                }
            }

            Console.WriteLine(tempstr.Substring(maxWordStartIndex, maxWordLength));
        }
    }
}
