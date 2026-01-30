namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            //int num = queue[2];

            foreach(int i in queue)
                Console.WriteLine(i);


            int num = queue.Dequeue();
            Console.WriteLine("\nnum = " + num);
            Console.WriteLine("Total items: " + queue.Count);
            
            foreach (int i in queue)
                Console.WriteLine(i);


            num = queue.Peek();
            Console.WriteLine("\nnum = " + num);
            Console.WriteLine("Total items: " + queue.Count);

            foreach (int i in queue)
                Console.WriteLine(i);
        }
    }
}
