namespace ProblemSolving
{
    internal class Implementation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Press the buttons for using different searching techniques...");
            Console.WriteLine("\n---------------- Searching Algorithms -------------------\n");
            while (true)
            {
                Console.WriteLine("1 ==================> Linear Search");
                Console.WriteLine("2 ==================> Binary Search");
                Console.WriteLine("3 ==================> Exit\n");
                Console.WriteLine("Press any button:");
                int button;
                if(!int.TryParse(Console.ReadLine(), out button))
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                    continue;
                }
                if(button == 3)
                {
                    Console.WriteLine("Exiting...GoodBye!");
                    break;
                }
                switch (button)
                {
                    case 1:
                        Console.Write("Enter array elements separated by space: ");
                        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        Console.Write("Enter the key to search: ");
                        if (!int.TryParse(Console.ReadLine(), out int key))
                        {
                            Console.WriteLine("Invalid key input. Please enter a valid number.");
                            continue;
                        }
                        SearchingMethods.LinearSearch(arr, key);
                        break;
                    case 2:
                        Console.Write("Enter array elements separated by space: ");
                        int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        Array.Sort(arr1);
                        Console.Write("Enter the key to search: ");
                        if (!int.TryParse(Console.ReadLine(), out int target))
                        {
                            Console.WriteLine("Invalid key input. Please enter a valid number.");
                            continue;
                        }
                        int result = SearchingMethods.BinarySearch(arr1, target);
                        if (result != -1)
                        {
                            Console.WriteLine($"Element found at index: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Element not found in the array.");
                        }
                        break;
                }
            }
        }
    }
}
