namespace ProblemSolving
{
    public class DoublyNode
    {
        public int data;
        public DoublyNode next;
        public DoublyNode prev;

        public DoublyNode(int value)
        {
            this.data = value;
        }

        public DoublyNode(int value, DoublyNode next, DoublyNode prev) : this(value)
        {
            this.next = next;
            this.prev = prev;
        }
    }
}
