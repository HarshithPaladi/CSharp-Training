namespace MoreQns
{
    internal class Program
    {
        //1) Write a program in C# Sharp to count a total number of duplicate elements in an array.
        //2) Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
        //3) Write a program in C# Sharp to separate odd and even integers in separate arrays
        static void Main(string[] args)
        {
            Console.WriteLine("Enter which prog to run: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            switch (a1)
            {
                case 1:
                    // 1
                    Dictionary<int, int> hashtable = new Dictionary<int, int>();
                    Console.Write("Enter elements in Single Line with Space: ");
                    List<int> arr = Console.ReadLine().TrimEnd().Split(" ").ToList().Select(x => Convert.ToInt32(x)).ToList();
                    int count = 0;
                    foreach (int i in arr)
                    {
                        hashtable[i] = (hashtable.TryGetValue(i, out var value) ? value : 0) + 1;
                    }
                    foreach (KeyValuePair<int, int> item in hashtable)
                    {
                        if (item.Value > 1) count++;
                    }
                    Console.WriteLine($"No. of Duplicate elements in array are :{count}");
                    break;
                case 2:
                    Dictionary<int, int> hashtable1 = new Dictionary<int, int>();
                    Console.Write("Enter elements in Single Line with Space: ");
                    List<int> arr1 = Console.ReadLine().TrimEnd().Split(" ").ToList().Select(x => Convert.ToInt32(x)).ToList();
                    Console.Write("\nEnter elements in Single Line with Space: ");
                    List<int> arr2 = Console.ReadLine().TrimEnd().Split(" ").ToList().Select(x => Convert.ToInt32(x)).ToList();
                    arr1 = arr1.Concat(arr2).ToList();
                    arr1.Sort();
                    Console.Write($"[{string.Join(",", arr1)}]");
                    break;
                case 3:
                    Console.Write("Enter elements in Single Line with Space: ");
                    List<int> arr3 = Console.ReadLine().TrimEnd().Split(" ").ToList().Select(x => Convert.ToInt32(x)).ToList();
                    List<int> oddList = new List<int>();
                    List<int> evenList = new List<int>();
                    foreach (var a in arr3)
                    {

                        if ((a & 1) == 1) oddList.Add(a);
                        else evenList.Add(a);
                    }
                    Console.WriteLine($"Odd list:[{string.Join(",", oddList)}]");
                    Console.WriteLine($"Even list:[{string.Join(",", evenList)}]");
                    break;


            }
        }
    }
}