namespace ProblemSolving
{
    internal class MergeArrays
    {
        public static void MergeTwoSortedArrays(int[] arr1, int[] arr2)
        {
            List<int> mergedArray = new List<int>();
            int first = 0, second = 0;
            while (first < arr1.Length && second < arr2.Length)
            {
                if (arr1[first] < arr2[second])
                {
                    mergedArray.Add(arr1[first]);
                    first++;
                }
                else
                {
                    mergedArray.Add(arr2[second]);
                    second++;
                }
            }
            while (first < arr1.Length)
            {
                mergedArray.Add(arr1[first]);
                first++;
            }
            while (second < arr2.Length)
            {
                mergedArray.Add(arr2[second]);
                second++;
            }
            Console.WriteLine("Merged Array: ");
            foreach (int number in mergedArray)
            {
                Console.Write(number + " ");
            }
        }
    }
}


