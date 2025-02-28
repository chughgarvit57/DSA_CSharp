namespace ProblemSolving
{
    internal class AnagramProgram
    {
        public static void AreAnagrams(string str1, string str2)
        {
            bool isAnagram = true;
            if (str1.Length != str2.Length)
            {
                isAnagram = false;
            }
            List<char> str1Chars = new List<char>(str1.ToLower().ToCharArray());
            List<char> str2Chars = new List<char>(str2.ToLower().ToCharArray());
            str1Chars.Sort();
            str2Chars.Sort();
            for(int i = 0; i < str1Chars.Count; i++)
            {
                if (str1Chars[i] != str2Chars[i])
                {
                    isAnagram = false;
                }
            }
            if(isAnagram)
            {
                Console.WriteLine($"{str1} and {str2} are anagrams.");
            }
            else
            {
                Console.WriteLine($"{str1} and {str2} are not anagrams.");
            }
        }
    }
}
