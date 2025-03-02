namespace ProblemSolving
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        public static int size = 0;

        public void InsertFirst(int value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
            if (tail == null)
            {
                tail = head;
            }
            size++;
        }

        public void InsertAt(int value, int index)
        {
            if (index == 0)
            {
                InsertFirst(value);
                return;
            }
            if (index == size)
            {
                InsertLast(value);
                return;
            }
            Node temp = head;
            for (int i = 1; i < index; i++)
            {
                temp = temp.next;
            }
            Node newNode = new Node(value, temp.next);
            temp.next = newNode;
            size++;
        }

        public void InsertLast(int value)
        {
            Node newNode = new Node(value);
            if (tail == null)
            {
                InsertFirst(value);
                return;
            }
            tail.next = newNode;
            tail = newNode;
            size++;
        }

        // Deletion in linked list
        public int DeleteFirst()
        {
            int value = head.data;
            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            size--;
            return value;
        }

        public Node Get(int index)
        {
            Node node = head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }
            return node;
        }

        public Node FindNode(int value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.data == value)
                {
                    return node;
                }
                node = node.next;
            }
            return null;
        }

        public int DeleteLast()
        {
            if (size <= 1)
            {
                return DeleteFirst();
            }
            Node secondLast = Get(size - 2);
            int value = tail.data;
            tail = secondLast;
            tail.next = null;
            size--;
            return value;
        }

        public int DeleteAt(int index)
        {
            if (index == 0)
            {
                return DeleteFirst();
            }
            if (index == size - 1)
            {
                return DeleteLast();
            }
            Node prev = Get(index - 1);
            int value = prev.next.data;
            prev.next = prev.next.next;
            size--;
            return value;
        }

        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("END");
        }
    }
}
