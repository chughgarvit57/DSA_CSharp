namespace ProblemSolving
{
    internal class CountVowelsAndConsonants
    {
        public static void CountVowelsAndConsonantsProgram()
        {
            Console.WriteLine("Enter a string to count vowels and consonants:");
            string input = Console.ReadLine();
            int vowels = 0;
            int consonants = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' ||
                    input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    vowels++;
                }
                else if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                {
                    consonants++;
                }
            }
            Console.WriteLine($"Vowels: {vowels}");
            Console.WriteLine($"Consonants: {consonants}");
        }
    }
}
