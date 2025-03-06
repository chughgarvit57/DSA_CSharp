namespace ProblemSolving
{
    class Implementations
    {
        public static void Main()
        {
            LinkedListStack myStack = new LinkedListStack();
            Console.WriteLine("Press buttons for the required tasks!");
            while (true)
            {
                Console.WriteLine("\n------------------ Stack Operations ----------------------\n");
                Console.WriteLine("1 -------------------> Push Element Onto Stack");
                Console.WriteLine("2 -------------------> Pop Element From Stack");
                Console.WriteLine("3 -------------------> Get the Peek Element of Stack");
                Console.WriteLine("4 -------------------> Get the size of Stack");
                Console.WriteLine("5 -------------------> Display Stack\n");
                int button;
                Console.Write("Press any button: ");
                if(!int.TryParse(Console.ReadLine(), out button))
                {
                    Console.WriteLine("Invalid Input! Please enter a number.");
                    continue;
                }
                switch (button)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        int pusheElem = Convert.ToInt32(Console.ReadLine());
                        myStack.Push(pusheElem);
                        break;
                    case 2:
                        int popValue = myStack.Pop();
                        Console.Write("Popped from stack: {0)" , popValue);
                        break;
                    case 3:
                        myStack.Peek();
                        break;
                    case 4:
                        int size = myStack.Size;
                        Console.Write("The size is: {0}" , size);
                        break;
                    case 5:
                        myStack.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid button! Please press a valid button.");
                        break;
                }
                Console.WriteLine("\nDo you wish to continue? (y/n)");
                string confirmation = Console.ReadLine();
                if(confirmation == "n")
                {
                    Console.WriteLine("Exiting... Have A Nice Day!");
                    break;
                }
            }
        }
    }
}
