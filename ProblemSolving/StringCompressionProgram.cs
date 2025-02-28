using System.Text;

namespace ProblemSolving
{
    internal class StringCompressionProgram
    {
        public static void CompressString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is empty.");
                return;
            }
            string compressedString = "";
            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 1 && str[i] == str[i + 1])
                {
                    count++;
                }
                else
                {
                    compressedString += str[i] + count.ToString();
                    count = 1;
                }
            }
            Console.WriteLine($"Compressed String: {compressedString}");
        }
    }
}
