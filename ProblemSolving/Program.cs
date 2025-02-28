namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press buttons for seeing the solutions to the problems given below:");
            while (true)
            {
                Console.WriteLine("Press 1 for ---------------> Reverse A String Program");
                Console.WriteLine("Press 2 for ---------------> Palindrome Check Program");
                Console.WriteLine("Press 3 for ---------------> Anagram Check Program");
                Console.WriteLine("Press 4 for ---------------> Count Vovwels & Consonants Program");
                Console.WriteLine("Press 5 for ---------------> String Compression Program");
                Console.WriteLine("Press 6 for ---------------> Find the First Non-Repeating Character Program\n");
                Console.WriteLine("Press any button:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a string:");
                        string str = Console.ReadLine();
                        ReverseString.ReverseAString(str);
                        break;
                    case 2:
                        Console.WriteLine("Enter a string:");
                        string str2 = Console.ReadLine();
                        PalindromeProgram.PalindromeCheck(str2);
                        break;
                    case 3:
                        Console.WriteLine("Enter the first string:");
                        string str3 = Console.ReadLine();
                        Console.WriteLine("Enter the second string:");
                        string str4 = Console.ReadLine();
                        AnagramProgram.AreAnagrams(str3, str4);
                        break;
                    case 4:
                        CountVowelsAndConsonants.CountVowelsAndConsonantsProgram();
                        break;
                    case 5:
                        Console.WriteLine("Enter a string:");
                        string str6 = Console.ReadLine();
                        StringCompressionProgram.CompressString(str6);
                        break;
                    case 6:
                        Console.WriteLine("Enter a string:");
                        string str7 = Console.ReadLine();
                        NonRepeatingCharacter.FirstNonRepeatingCharacterProgram(str7);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.WriteLine("\nDo you wish to continue(y/n)?");
                char confirm = Convert.ToChar(Console.ReadLine());
                if(confirm == 'n')
                {
                    Console.WriteLine("Exiting...\nGoodBye....!");
                    break;
                }
            }
        }
    }
}
