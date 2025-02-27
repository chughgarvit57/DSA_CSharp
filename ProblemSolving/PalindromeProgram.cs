namespace ProblemSolving
{
    internal class PalindromeProgram
    {
        public static void PalindromeCheck(string str)
        {
            string copy_str = str;
            string reversedStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }
            if (copy_str.Equals(reversedStr,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\"{str}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\"{str}\" is not a palindrome.");
            }
        }
    }
}
