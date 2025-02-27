namespace ProblemSolving
{
    internal class ReverseString
    {
        public static void ReverseAString(string str)
        {
            /*for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }*/
            string reversedStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }
            Console.Write(reversedStr);
        }
    }
}
