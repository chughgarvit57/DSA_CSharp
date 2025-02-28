namespace ProblemSolving
{
    internal class SearchingInArray
    {
        public static void SearchInArray(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    Console.WriteLine($"{key} found at index: " + i);
                    return;
                }
            }
            Console.WriteLine($"{key} not found in the array.");
        }
    }
}
