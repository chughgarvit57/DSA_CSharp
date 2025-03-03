namespace ProblemSolving
{
    public class CircularLinkedList
    {
        private Node head;
        private Node tail;
        public static int size = 0;

        public void InsertFirst(int value)
        {
            Node node = new Node(value);
            if(head == null)
            {
                head = tail = node;
                tail.next = head;
            }
            node.next = head;
            tail.next = node;
            head = node;
            size++;
        }

        public void InsertLast(int value)
        {
            Node node = new Node(value);
            if(head == null)
            {
                head = tail = node;
                tail.next = head;
            }
            node.next = head;
            tail.next = node;
            tail = node;
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
            Node node = new Node(value);
            Node temp = head;
            for(int i = 0; i < index - 1; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
            size++;
        }

        // Deletion in circular linked list
        public void DeleteFirst()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            if(head == tail)
            {
                head = tail = null;
            } 
            head = head.next;
            tail.next = head;
            size--;
        }

        public void DeleteLast()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            if(head == tail)
            {
                head = tail = null;
            }
            Node temp = head;
            while(temp.next != tail)
            {
                temp = temp.next;
            }
            temp.next = head;
            tail = temp;
            size--;
        }

        public void DeleteAt(int index)
        {
            if(index < 0 || index > size)
            {
                Console.WriteLine("Invalid Index!");
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
            Node temp = head;
            for(int i = 0; i < index - 1; i++)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
            size--;
        }

        public int Delete(int value)
        {
            if(head == null)
            {
                Console.WriteLine("List is empty.");
                return -1;
            }
            if(head.data == value)
            {
                DeleteFirst();
                return value;
            }
            Node temp = head;
            do
            {
                Node next = temp.next;
                if(next.data == value)
                {
                    temp.next = next.next;
                    if(next == tail)
                    {
                        tail = temp;
                    }
                    size--;
                    return value;
                }
                temp = temp.next;
            } while (temp != head);
            Console.WriteLine("Value not found!");
            return -1;
        }

        public void Display()
        {
            Node temp = head;
            if(head != null)
            {
                do
                {
                    Console.Write(temp.data + " - ");
                    temp = temp.next;
                } while(temp != head);
            }
            Console.WriteLine("HEAD");
        }
    }
}
