namespace ProblemSolving
{
    internal class MoveAllZeroesEnd
    {
        public static void MoveAllZeroesInEnd(int[] arr)
        {
            // Ex Arr - [0, 1, 0, 3, 12]
            // Ex O/P - [1, 3, 12, 0, 0]
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count++] = arr[i];
                }
            }
            while (count < arr.Length)
            {
                arr[count++] = 0;
            }
            Console.WriteLine("Array after moving zeroes in end:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
