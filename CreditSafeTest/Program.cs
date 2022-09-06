using System;
using System.Collections.Generic;

namespace CreditSafeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "HeLovesCheeseBiscuits";
            var response = CreateSpaceInWords(inputString);
            Console.WriteLine(response);

        }

        private static string CreateSpaceInWords(string input)
        {
            string totalWord = "";
            for (int i = 0; i < input.Length; i++)
            {
                var character = input[i]; 
                if (char.IsUpper(character))
                {
                    totalWord += " ";
                    totalWord += character.ToString();
                }
                else
                {
                    totalWord += character.ToString();
                }
            }
            return totalWord;
        }
    }
}

