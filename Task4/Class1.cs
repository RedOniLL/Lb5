using System;

namespace Lb5.Task4
{
    public static class Class1
    {
        public static void Task()
        {
            
            
            Console.Write("Enter the number of vowels: ");
            int numVowels = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of consonants: ");
            int numConsonants = int.Parse(Console.ReadLine());

            Console.Write("Enter the maximum word length: ");
            int maxWordLength = int.Parse(Console.ReadLine());

            
            string pseudoText = GeneratePseudoText(numVowels, numConsonants, maxWordLength);

            
            Console.WriteLine("\nGenerated pseudo-text:");
            Console.WriteLine(pseudoText);
        }

        static string GeneratePseudoText(int numVowels, int numConsonants, int maxWordLength)
        {
            Random random = new Random();
            string vowels = "aeiou";
            string consonants = "bcdfghjklmnpqrstvwxyz";
            string pseudoText = "";

            for (int i = 0; i < numVowels; i++)
            {
                pseudoText += vowels[random.Next(vowels.Length)];
            }

            for (int i = 0; i < numConsonants; i++)
            {
                pseudoText += consonants[random.Next(consonants.Length)];
            }

            pseudoText = pseudoText.Replace(" ", "");

            if (pseudoText.Length > maxWordLength)
            {
                pseudoText = pseudoText.Substring(0, maxWordLength);
            }

            return pseudoText;
        }
    }
}

