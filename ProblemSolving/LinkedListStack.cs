namespace ProblemSolving
{
    public class LinkedListStack
    {
        private Node top;
        private int size = 0;
        public int Size { get { return size; } }

        // function to check whether stack is empty
        public bool IsEmpty()
        {
            return size == 0;
        }

        // function to push element in the stack
        public void Push(int value)
        {
            Node node = new Node(value);
            if(top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            size++;
            Console.WriteLine($"{value} pushed onto the stack.");
        }

        // funtion to pop element from the stack
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow. Insert Values First!");
                return -1;
            }
            int poppedValue = top.data;
            top = top.next;
            size--;
            Console.WriteLine($"{poppedValue} popped from stack.");
            return poppedValue;
        }

        // function to get the peek(top) element of the stack
        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow. Insert Values First!");
                return;
            }
            int peekValue = top.data;
            Console.WriteLine($"Peek element of the stack is: {peekValue}");
        }

        // function to display the stack
        public void Display()
        {
            Node temp = top;
            Console.WriteLine("Elements in the stack:");
            while(temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }
    }
}
