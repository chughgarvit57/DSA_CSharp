namespace ProblemSolving
{
    public class Sorting
    {
        public static int[] BubbleSort(int[] arr, int size)
        {
            for (int i = 0; i < size - 1; i++)
            {
                bool isSwap = false;
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap the numbers
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        isSwap = true;
                    }
                }
                if (!isSwap) // array is already sorted
                {
                    return arr;
                }
            }
            return arr;
        }

        public static int[] SelectionSort(int[] arr, int size)
        {
            for (int i = 0; i < size - 1; i++)
            {
                int smallestIdx = i; // unsorted part starting index
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[j] < arr[smallestIdx])
                    {
                        smallestIdx = j;
                    }
                }
                // Now swap the elements
                int temp = arr[i];
                arr[i] = arr[smallestIdx];
                arr[smallestIdx] = temp;
            }
            return arr;
        }

        public static int[] InsertionSort(int[] arr, int size)
        {
            for (int i = 1; i < size; i++)
            {
                int current = arr[i];
                int prev = i - 1;
                while (prev >= 0 && arr[prev] > current)
                {
                    arr[prev + 1] = arr[prev];
                    prev--;
                }
                arr[prev + 1] = current; // placing the current element at its correct position
            }
            return arr;
        }

        public static void Divide(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int mid = start + (end - start) / 2;
            Divide(arr, start, mid);
            Divide(arr, mid + 1, end);
            Conquer(arr, start, mid, end);
        }

        public static void Conquer(int[] arr, int start, int mid, int end)
        {
            int[] mergedArray = new int[end - start + 1];
            int idx1 = start;
            int idx2 = mid + 1;
            int x = 0;

            while (idx1 <= mid && idx2 <= end)
            {
                if (arr[idx1] <= arr[idx2])
                {
                    mergedArray[x++] = arr[idx1++];
                }
                else
                {
                    mergedArray[x++] = arr[idx2++];
                }
            }

            while (idx1 <= mid)
            {
                mergedArray[x++] = arr[idx1++];
            }

            while (idx2 <= end)
            {
                mergedArray[x++] = arr[idx2++];
            }

            for (int i = 0, j = start; i < mergedArray.Length; i++, j++)
            {
                arr[j] = mergedArray[i];
            }
        }
    }
}
