using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press the buttons for seeing the solutions to the problems listed below:\n");
            while (true)
            {
                Console.WriteLine("==================== Arrays ========================\n");
                Console.WriteLine("1 --------------------> Find All Pairs with a Given Sum Program");
                Console.WriteLine("2 --------------------> Searching in an Array Program");
                Console.WriteLine("3 --------------------> Move All Zeros to the End Program");
                Console.WriteLine("4 --------------------> Find the Duplicate Number Program");
                Console.WriteLine("5 --------------------> Merge Two Sorted Arrays Program");
                Console.WriteLine("6 --------------------> Find the Majority Element Program\n");
                Console.WriteLine("Press any button:");

                if (!int.TryParse(Console.ReadLine(), out int button))
                {
                    Console.WriteLine("Invalid Input. Please enter a number.");
                    continue;
                }

                switch (button)
                {
                    case 1:
                        Console.WriteLine("Enter array elements separated by spaces:");
                        int[] arr1 = ReadIntArray();
                        Console.WriteLine("Enter target sum:");
                        int sum = int.Parse(Console.ReadLine());
                        PairSum.CalculatePairSum(arr1, sum);
                        break;
                    case 2:
                        Console.WriteLine("Enter array elements separated by spaces:");
                        int[] arr2 = ReadIntArray();
                        Console.WriteLine("Enter the target number:");
                        int target = int.Parse(Console.ReadLine());
                        SearchingInArray.SearchInArray(arr2, target);
                        break;
                    case 3:
                        Console.WriteLine("Enter array elements separated by spaces:");
                        int[] arr3 = ReadIntArray();
                        MoveAllZeroesEnd.MoveAllZeroesInEnd(arr3);
                        break;
                    case 4:
                        Console.WriteLine("Enter array elements separated by spaces:");
                        int[] arr4 = ReadIntArray();
                        DuplicateNumber.FindDuplicateNumber(arr4);
                        break;
                    case 5:
                        Console.WriteLine("Enter first sorted array elements separated by spaces:");
                        int[] arr5 = ReadIntArray();
                        Console.WriteLine("Enter second sorted array elements separated by spaces:");
                        int[] arr6 = ReadIntArray();
                        MergeArrays.MergeTwoSortedArrays(arr5, arr6);
                        break;
                    case 6:
                        Console.WriteLine("Enter array elements separated by spaces:");
                        int[] arr7 = ReadIntArray();
                        MajorityElement.FindMajorityElement(arr7);
                        break;
                    default:
                        Console.WriteLine("Invalid Button");
                        break;
                }

                Console.WriteLine("\nDo you wish to continue(y/n)?");
                string confirmation = Console.ReadLine();
                if (confirmation.ToLower() == "n")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
            }
        }

        static int[] ReadIntArray()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
