namespace ProblemSolving
{
    internal class PairSum
    {
        public static void CalculatePairSum(int[] arr, int sum)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine("[" + arr[i] + ", " + arr[j] + "]");
                    }
                }
            }
        }
    }
}
