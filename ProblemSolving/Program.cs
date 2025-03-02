namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the linked list branch. Here implementation is done.\n");
            LinkedList list = new LinkedList();
            list.InsertLast(10);
            list.InsertLast(9);
            list.InsertLast(8);
            list.InsertLast(7);
            list.InsertLast(6);
            list.InsertLast(5);
            list.Display();
            Console.WriteLine($"\nThe size of this list is: {LinkedList.size}");
            Console.WriteLine(list.DeleteFirst() + " => Deleted");
            Console.WriteLine("------------------------------------");
            list.Display();
            Console.WriteLine($"\nThe size of this list is: {LinkedList.size}");
            Console.WriteLine(list.DeleteLast() + " => Deleted");
            Console.WriteLine("------------------------------------");
            list.Display();
            Console.WriteLine($"\nThe size of this list is: {LinkedList.size}");
            list.DeleteAt(2);
            Console.WriteLine("Value at index 3 deleted:\nUpdated List:");
            list.Display();
            Console.WriteLine($"\nThe size of this list is: {LinkedList.size}");
        }
    }
}
