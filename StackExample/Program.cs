namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            //int num = stack[2];

            foreach (int i in stack)
                Console.WriteLine(i);


            int num = stack.Pop();
            Console.WriteLine("\n\nnum = " + num);
            Console.WriteLine("Total items: " + stack.Count);

            foreach (int i in stack)
                Console.WriteLine(i);


            num = stack.Peek();
            Console.WriteLine("\n\nnum = " + num);
            Console.WriteLine("Total items: " + stack.Count);

            foreach (int i in stack)
                Console.WriteLine(i);
        }
    }
}
