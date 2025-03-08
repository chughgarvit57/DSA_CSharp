using System.Security.AccessControl;

namespace ProblemSolving
{
    public class SearchingMethods
    {
        public static void LinearSearch(int[] arr , int key)
        {
            bool found = false;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine($"{key} found in the array.");
            } 
            else
            {
                Console.WriteLine($"{key} not found in the array.");
            }
        }

        public static int BinarySearch(int[] arr , int key)
        {
            int left = 0, right = arr.Length - 1;

            while(left <= right)
            {
                int mid = left + (right - left) / 2;

                // checking if target found at mid
                if (arr[mid] == key)
                {
                    return mid;
                }
                if(key > arr[mid])
                {
                    left = mid + 1;
                } 
                else
                {
                    right = mid - 1;
                }
            }
            // key not present in array
            return -1;
        }
    }
}
