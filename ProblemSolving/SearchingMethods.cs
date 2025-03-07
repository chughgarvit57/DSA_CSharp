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
    }
}
