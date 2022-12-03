namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues Problem\n");
            stackAndQueue stack = new stackAndQueue();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("\nThe Elements Are Present In The Stack");
            stack.Display();
        }
    }
}