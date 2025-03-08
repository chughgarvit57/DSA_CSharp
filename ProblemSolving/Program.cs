using System.Collections.Generic;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome To HashSet Tutorial.\n");

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };
            set1.Add(10);
            set1.Add(20);
            set1.Add(30);
            set1.Add(40);
            Console.WriteLine("Elements in the hashset- 'set1' :");
            foreach (int number in set1)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Elements Count Before Removal: {0}", set1.Count);
            set1.Remove(10);
            Console.WriteLine("Elements Count After Removal: {0}", set1.Count);
            set1.Clear();
            Console.WriteLine("Elements Count after running the clear() method: {0}", set1.Count);
            set1.Add(12);
            set1.Add(16);
            set1.Add(23);
            set1.Add(31);
            set1.Add(39);
            set1.Add(43);
            int result = set1.RemoveWhere(num => num > 35); // removes the numbers where number > 35 and returns
            // the total number of elements removed
            Console.WriteLine("After applying RemoveWhere():");
            foreach (int number in set1)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");

            HashSet<int> set3 = new HashSet<int> { 1,2,3,4,5 };
            HashSet<int> set4 = new HashSet<int> { 6,7,8 };
            HashSet<int> set5 = new HashSet<int> { 9,10 };
            set3.UnionWith(set4);
            Console.WriteLine("Set3 Union With Set4:");
            foreach(int num in set3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n---------------------");
            set3.IntersectWith(set4);
            Console.WriteLine("Set3 Intersection With Set4:");
            foreach (int num in set3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n---------------------");
            set3.ExceptWith(set4);
            Console.WriteLine("remove from set3 all elements that exist in set4:");
            foreach (int num in set3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n---------------------");
        }
    }
}
