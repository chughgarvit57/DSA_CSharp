namespace ProblemSolving
{
    public class LinkedListQueue
    {
        private Node front, rear;
        private int size = 0;
        public int Size { get { return size; } }

        // function to check whether queue is empty
        public bool IsEmpty()
        {
            return size == 0;
        }

        // function to add elements in the queue
        public void EnQueue(int value)
        {
            Node node = new Node(value);
            if(rear == null)
            {
                front = rear = node;
                Console.WriteLine($"{value} added in the queue.");
                size++;
                return;
            }
            rear.next = node;
            rear = node;
            size++;
            Console.WriteLine($"{value} added to the queue.");
        }

        // function to remove element from the queue
        public void DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow. Insert Values first...");
                return;
            }
            int removedElement = front.data;
            front = front.next;
            size--;
            if(front == null)
            {
                rear = null;
            }
            Console.WriteLine("Element removed from the queue: {0}" , removedElement);
        }

        // function to get the front element in the queue
        public void GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow. Insert values first...");
                return;
            }
            int frontElement = front.data;
            Console.WriteLine("Front element in the queue is: {0}" , frontElement);
        }

        // function to get the rear element in the queue
        public void GetRear()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow. Insert values first...");
                return;
            }
            int rearElement = rear.data;
            Console.WriteLine("Rear element in the queue is: {0}", rearElement);
        }

        // function to display queue elements
        public void Display()
        {
            Node temp = front;
            Console.WriteLine("Elements in the queue:");
            while(temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }
    }
}
