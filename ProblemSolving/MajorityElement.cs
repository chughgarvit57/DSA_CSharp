namespace ProblemSolving
{
    internal class MajorityElement
    {
        public static void FindMajorityElement(int[] arr)
        {
            int majorityElement = arr[0];
            int count = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == majorityElement)
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if (count == 0)
                {
                    majorityElement = arr[i];
                    count = 1;
                }
            }
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == majorityElement)
                {
                    count++;
                }
            }
            if (count > arr.Length / 2)
            {
                Console.WriteLine("Majority Element: " + majorityElement);
            }
            else
            {
                Console.WriteLine("No Majority Element");
            }
        }
    }
}
