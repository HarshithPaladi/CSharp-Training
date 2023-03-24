using System.Collections.Generic;

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
            Console.WriteLine("\nLinked Lists\n");
            // Linked List
            var MyLinkedList = new LinkedList<int>();
            var myLinkedList1 = new LinkedList<int>();
            MyLinkedList.AddLast(1);
            MyLinkedList.AddLast(2);
            MyLinkedList.AddLast(3);
            MyLinkedList.AddLast(4);
            MyLinkedList.AddLast(5);
            MyLinkedList.AddLast(2);
            MyLinkedList.AddLast(3);

            //LinkedListNode<int> node = MyLinkedList.Find(2);
            //LinkedListNode<int> node1 = MyLinkedList.FindLast(2);

            //MyLinkedList.AddBefore(node, 10);
            //MyLinkedList.AddBefore(node1, 10);
            foreach (var i in MyLinkedList)
            {
                if (i == 2)
                {
                    myLinkedList1.AddLast(10);

                }
                myLinkedList1.AddLast(i);
            }

            foreach (int i in myLinkedList1)
            {
                Console.WriteLine(i);
            }

            // Dictionaries
            Console.WriteLine("Dictionaries\n");
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Harshith");
            d.Add(2, "Sravani");
            d.Add(3, "Maha");
            d.Add(4, "Akshai");
            d.Add(5, "Rahul");
            d.Add(6, "Rahul");
            d.Add(7, "");
            Console.WriteLine(d.ContainsValue("Harshith"));
            d.Remove(6);
            if (d.ContainsValue("Rahul"))
            {
                d[5] = "CHANGED";
            }
            foreach (KeyValuePair<int, string> kvp in d)
            {
                if (kvp.Value.Equals("Maha"))
                {
                    d[kvp.Key] = "MAHA";
                }
            }
            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine(kvp.Key+ " = " + kvp.Value);
            }

            Console.WriteLine(d.GetValueOrDefault(8, "DEFAULT"));
            // Sorted Dictionary
            Console.WriteLine("Sorted Dictionary");
            SortedDictionary<string,string> Sd = new SortedDictionary<string,string>(); ;
            Sd.Add("a", "Apple");
            Sd.Add("b", "Ball");
            Sd.Add("c", "Cat");
            Sd.Add("D", "dog");
            Sd.Add("1", "one");
            Sd.Add("2", "");
            foreach(var item in Sd.OrderBy(x => x.Value)) 
            {
                Console.WriteLine(item);
                if (item.Value == "one")
                {
                    Sd.Remove(item.Key);
                }
            }

            foreach(KeyValuePair<string,string> item in Sd)
            {
                if (item.Value.Equals("one"))
                {
                    Sd.Remove(item.Key);
                }
            }
            foreach(var key in Sd)
            {
                Console.WriteLine(key.Key +  " = " + key.Value);
            }

            // Sorted Lists

        }
    }
}