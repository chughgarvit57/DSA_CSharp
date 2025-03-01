namespace ProblemSolving
{
    internal class DuplicateNumber
    {
        public static void FindDuplicateNumber(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    Console.WriteLine($"Duplicate number in the array is: {arr[i]}");
                    return;
                }
            }
            Console.WriteLine("No duplicate found.");
        }
    }
}
