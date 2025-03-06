namespace ProblemSolving
{
    class Implementaions
    {
        static void Main(string[] args)
        {
            LinkedListQueue queue = new LinkedListQueue();
            Console.WriteLine("Press buttons for the required tasks!");
            while (true)
            {
                Console.WriteLine("\n------------------ Queue Operations ----------------------\n");
                Console.WriteLine("1 -------------------> Insert Element into Queue");
                Console.WriteLine("2 -------------------> Remove Element From Queue");
                Console.WriteLine("3 -------------------> Get the Front Element of Queue");
                Console.WriteLine("4 -------------------> Get the Rear Element of Queue");
                Console.WriteLine("5 -------------------> Get the size of Queue");
                Console.WriteLine("6 -------------------> Display Queue\n");
                int button;
                Console.Write("Press any button: ");
                if (!int.TryParse(Console.ReadLine(), out button))
                {
                    Console.WriteLine("Invalid Input! Please enter a number.");
                    continue;
                }
                switch (button)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        int pusheElem = Convert.ToInt32(Console.ReadLine());
                        queue.EnQueue(pusheElem);
                        break;
                    case 2:
                        queue.DeQueue();
                        break;
                    case 3:
                        queue.GetFront();
                        break;
                    case 4:
                        queue.GetRear();
                        break;
                    case 5:
                        int size = queue.Size;
                        Console.Write("The size is: {0}", size);
                        break;
                    case 6:
                        queue.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid button! Please press a valid button.");
                        break;
                }
                Console.WriteLine("\nDo you wish to continue? (y/n)");
                string confirmation = Console.ReadLine();
                if (confirmation == "n")
                {
                    Console.WriteLine("Exiting... Have A Nice Day!");
                    break;
                }
            }
        }
    }
}
