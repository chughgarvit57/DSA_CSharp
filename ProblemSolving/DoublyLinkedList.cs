namespace ProblemSolving
{
    public class DoublyLinkedList
    {
        private DoublyNode head;
        public static int size = 0;

        public void InsertFirst(int value)
        {
            DoublyNode node = new DoublyNode(value);
            node.next = head;
            node.prev = null;
            if(head != null)
            {
                head.prev = node;
            }
            head = node;
            size++;
        }

        public void InsertLast(int value)
        {
            DoublyNode node = new DoublyNode(value);
            DoublyNode last = head;
            node.next = null;
            if(head == null)
            {
                node.prev = null;
                head = node;
                return;
            }
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = node;
            node.prev = last;
            size++;
        }

        public DoublyNode Find(int value)
        {
            DoublyNode node = head;
            while(node != null)
            {
                if(node.data == value)
                {
                    return node;
                }
                node = node.next;
            }
            return null;
        }

        public void Insert(int after, int value)
        {
            DoublyNode prev = Find(after);
            if(prev == null)
            {
                Console.WriteLine("Does not exist!");
                return;
            }
            DoublyNode node = new DoublyNode(value);
            node.next = prev.next;
            prev.next = node;
            node.prev = prev;
            if(node.next != null)
            {
                node.next.prev = node;
            }
            size++;
        }

        public void InsertAt(int index, int value)
        {
            if(index < 0 || index > size)
            {
                Console.WriteLine("Invalid Index!");
                return;
            }
            if(index == 0)
            {
                InsertFirst(value);
                return;
            }
            if(index == size)
            {
                InsertLast(value);
                return;
            }
            DoublyNode node = new DoublyNode(value);
            DoublyNode temp = head;
            for(int i = 0; i < index; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next.prev = node;
            temp.next = node;
            node.prev = temp;
            size++;
        }

        // Deletion in doubly linked list
        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            head = head.next;
            if(head != null)
            {
                head.prev = null;
            }
            size--;
        }

        public void DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            if(head.next == null)
            {
                head = null;
                size--;
                return;
            }
            DoublyNode last = head;
            while(last.next != null)
            {
                last = last.next;
            }
            last.prev.next = null;
            size--;
        }

        public void DeleteAt(int index, int value)
        {
            if( index < 0 || index > size)
            {
                Console.WriteLine("Invalid index!");
                return;
            }
            if(index == 0)
            {
                DeleteFirst();
                return;
            }
            if(index == size)
            {
                DeleteLast();
                return;
            }
            DoublyNode temp = head;
            for(int i = 0; i < index; i++)
            {
                temp = temp.next;
            }
            temp.prev.next = temp.next;
            if(temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            size--;
        }

        public void Display()
        {
            DoublyNode temp = head;
            DoublyNode last = null;
            while(temp != null)
            {
                Console.Write(temp.data + " <-> ");
                last = temp;
                temp = temp.next;
            }
            Console.WriteLine("End");
            Console.WriteLine("Reverse Printing:");
            while(last != null)
            {
                Console.Write(last.data + " <-> ");
                last = last.prev;
            }
            Console.WriteLine("Start");
        }
    }
}
