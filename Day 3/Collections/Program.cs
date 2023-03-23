namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ListDemo = new List<string>() { "new", "oraanges" };
            ListDemo.Add("Hello");
            ListDemo.Add("Hello2");
            ListDemo.Add("Hello1");

            foreach (var item in ListDemo)
            {
                Console.WriteLine(item);
            }
            ListDemo.Remove("Hello1");
            foreach (var item in ListDemo)
            { Console.WriteLine(item); }

            //Hashset
            var hashset1 = new HashSet<int>() { 1, 2, 3, 3, 4, 4, 5, 6 };
            hashset1.ToList().ForEach(x => Console.Write(x + " "));
            System.Console.WriteLine("\n");



            var ExampleIntegerSet = new SortedSet<int>() { 5, 1, 8, 2, 9, 0, 12 };
            var ExampleSet = new SortedSet<char>() { 'B', 'L', 'A', 'D' };
            foreach (var item in ExampleIntegerSet)
            {
                Console.WriteLine($" IntegerSet - {item}");
            }
            foreach (var item in ExampleSet)
            {
                Console.WriteLine($" CharSet - {item}");
            }
            // Stack
            Console.WriteLine("\nStacks");
            Stack<string> stack1 = new Stack<string>();
            stack1.Push("A");
            stack1.Push("B");
            stack1.Push("C");
            string peekvalue;
            while (stack1.Count != 0)
            {
                Console.Write(stack1.Pop());
                if (stack1.TryPeek(out peekvalue))
                {
                    Console.WriteLine($" | Peak Element: {peekvalue}");
                }
            }
            //Queue
            Console.WriteLine("\nQueue");
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("A");
            queue1.Enqueue("B");
            queue1.Enqueue("C");
            queue1.Enqueue("B");

            string q_peekvalue;
            while (queue1.Count != 0)
            {
                Console.Write(queue1.Dequeue());
                if (queue1.TryPeek(out q_peekvalue))
                {
                    Console.WriteLine($" | Peak Element: {q_peekvalue}");
                }
            }




        }
    }
}