namespace ProblemSolving
{
    internal class NonRepeatingCharacter
    {
        public static void FirstNonRepeatingCharacterProgram(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                bool isUnique = true;
                for(int j = 0; j < str.Length; j++)
                {
                    if (i != j && str[i] == str[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine($"First Non-Repeating Character: {currentChar}");
                    return;
                }
            }
            Console.WriteLine("No non-repeating character found.");
        }
    }
}
