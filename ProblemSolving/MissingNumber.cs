namespace ProblemSolving
{
    internal class MissingNumber
    {
        public static void FindMissingNumber(int[] arr)
        {
            int num = arr.Length + 1;
            int total = num * (num + 1) / 2;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int missingNumber = total - sum;
            Console.WriteLine($"Missing number in the array is: {missingNumber}");
        }
    }
}
