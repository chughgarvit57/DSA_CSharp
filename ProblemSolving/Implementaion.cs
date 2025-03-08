namespace ProblemSolving
{
    internal class Implementaion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Press the buttons for using different sorting techniques...");
            Console.WriteLine("\n--------------------  SORTING TECHNIQUES  --------------------\n");
            while (true)
            {
                Console.WriteLine("1 ---------------> Bubble Sort");
                Console.WriteLine("2 ---------------> Selection Sort");
                Console.WriteLine("3 ---------------> Insertion Sort");
                Console.WriteLine("4 ---------------> Merge Sort");
                Console.WriteLine("5 ---------------> Exit\n");
                Console.WriteLine("Press any button:");
                int button;
                if (!int.TryParse(Console.ReadLine(), out button))
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number");
                    continue;
                }
                if (button == 5)
                {
                    Console.WriteLine("Exiting....GoodBye!");
                    break;
                }
                switch (button)
                {
                    case 1:
                        int[] arr = { 1, 6, 2, 5, 4, 7, 9, 8 };
                        Console.WriteLine("Given array:");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.Write(arr[i] + " ");
                        }
                        int[] sortedArray = Sorting.BubbleSort(arr, arr.Length);
                        Console.WriteLine("\nSorted Array:");
                        for (int i = 0; i < sortedArray.Length; i++)
                        {
                            Console.Write(sortedArray[i] + " ");
                        }
                        break;
                    case 2:
                        int[] arr2 = { 1, 6, 2, 5, 4, 7, 9, 8 };
                        Console.WriteLine("Given array:");
                        for (int i = 0; i < arr2.Length; i++)
                        {
                            Console.Write(arr2[i] + " ");
                        }
                        int[] sortedArray2 = Sorting.SelectionSort(arr2, arr2.Length);
                        Console.WriteLine("\nSorted Array:");
                        for (int i = 0; i < sortedArray2.Length; i++)
                        {
                            Console.Write(sortedArray2[i] + " ");
                        }
                        break;
                    case 3:
                        int[] arr3 = { 1, 6, 2, 5, 4, 7, 9, 8 };
                        Console.WriteLine("Given array:");
                        for (int i = 0; i < arr3.Length; i++)
                        {
                            Console.Write(arr3[i] + " ");
                        }
                        int[] sortedArray3 = Sorting.InsertionSort(arr3, arr3.Length);
                        Console.WriteLine("\nSorted Array:");
                        for (int i = 0; i < sortedArray3.Length; i++)
                        {
                            Console.Write(sortedArray3[i] + " ");
                        }
                        break;
                    case 4:
                        int[] arr4 = { 1, 6, 2, 5, 4, 7, 9, 8 };
                        Console.WriteLine("Given array:");
                        for (int i = 0; i < arr4.Length; i++)
                        {
                            Console.Write(arr4[i] + " ");
                        }
                        Sorting.Divide(arr4, 0, arr4.Length - 1);
                        Console.WriteLine("\nSorted Array:");
                        for (int i = 0; i < arr4.Length; i++)
                        {
                            Console.Write(arr4[i] + " ");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid sorting option.");
                        break;
                }
                Console.Write("\nDo you want to continue? (yes/no): ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response != "yes" && response != "y")
                {
                    Console.WriteLine("Exiting....Goodbye!");
                    break;
                }
            }
        }
    }
}