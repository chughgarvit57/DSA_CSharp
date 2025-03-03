namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the linked list branch. Here implementation is done.\n");
            /*
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
            */
            // ******************************************************************************************

            /*
            DoublyLinkedList list = new DoublyLinkedList();
            list.InsertFirst(4);
            list.InsertFirst(3);
            list.InsertFirst(2);
            list.InsertFirst(1);
            list.InsertLast(50);
            list.Insert(after: 3, value: 100);
            list.Display();
            Console.WriteLine($"The size of doubly linked is: {DoublyLinkedList.size}");
            Console.WriteLine("-------------------------------------------------");
            list.InsertAt(2, 500);
            list.Display();
            Console.WriteLine($"The size of doubly linked is: {DoublyLinkedList.size}");
            Console.WriteLine("-------------------------------------------------");
            */
            // *****************************************************************************************

            CircularLinkedList list = new CircularLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertFirst(4);
            Console.WriteLine("Updated List:");
            list.Display();
            Console.WriteLine($"Size: {CircularLinkedList.size}");
            Console.WriteLine("-------------------------------");
            list.InsertLast(10);
            list.InsertLast(20);
            Console.WriteLine("Updated List:");
            list.Display();
            Console.WriteLine($"Size: {CircularLinkedList.size}");
            Console.WriteLine("-------------------------------");
            list.InsertAt(4, 100);
            Console.WriteLine("Updated List:");
            list.Display();
            Console.WriteLine($"Size: {CircularLinkedList.size}");
            Console.WriteLine("-------------------------------");
            list.DeleteFirst();
            Console.WriteLine("Updated List:");
            list.Display();
            Console.WriteLine($"Size: {CircularLinkedList.size}");
            Console.WriteLine("-------------------------------");
            list.DeleteLast();
            Console.WriteLine("Updated List:");
            list.Display();
            Console.WriteLine($"Size: {CircularLinkedList.size}");
            Console.WriteLine("-------------------------------");
            list.DeleteAt(2);
            Console.WriteLine("Updated List:");
            list.Display();
            Console.WriteLine($"Size: {CircularLinkedList.size}");
            Console.WriteLine("-------------------------------");
            list.Delete(100);
            Console.WriteLine("Updated List:");
            list.Display();
            Console.WriteLine($"Size: {CircularLinkedList.size}");
        }
    }
}
