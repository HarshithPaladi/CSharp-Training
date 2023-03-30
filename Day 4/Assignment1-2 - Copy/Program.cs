namespace Assignment1_2
{
    internal class ChocolateDispenser
    {
        public Dictionary<string, int> Chocolates = new Dictionary<string, int>();
        public int TotalChocolates = 0;
        public ChocolateDispenser()
        {
            Chocolates.Add("Red", 0);
            Chocolates.Add("White", 0);
            Chocolates.Add("Blue", 0);
            Chocolates.Add("Green", 0);
            Chocolates.Add("Yellow", 0);
        }
        public void addChocolates(string color, int count)
        {
            Chocolates[color] += count;
            TotalChocolates += count;
        }
        public void removeColorChocolates(string color)
        {
            if (Chocolates[color] != 0)
            {
                Chocolates[color]--;
                TotalChocolates--;
            }
        }
        public void changeChocolateColor(int count, string color, string newcolor)
        {
            if (count < Chocolates[color])
            {
                Chocolates[color]--;
                Chocolates[newcolor]++;
            }
        }
        public void noOfChocolates()
        {
            Console.WriteLine($"--------------------------------------");
            foreach (KeyValuePair<string, int> item in Chocolates)
            {
                Console.WriteLine($"[{item.Key}:  {item.Value}]");
            }
            Console.WriteLine($"--------------------------------------");

        }
        public Dictionary<string, int> dispenseChocolatesOfColor(string color, int count)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            if (count <= Chocolates[color])
            {
                result[color] = count;
                Chocolates[color] -= count;
                TotalChocolates -= count;
                Console.WriteLine($"--------------------------------------");
                Console.WriteLine($"Returned items are:");
                foreach (KeyValuePair<string, int> item in result)
                {
                    Console.WriteLine($"[{item.Key}, {item.Value}]");
                }
                Console.WriteLine($"--------------------------------------");
            }
            return result;
        }
        public int RemoveChocolates(int count)
        {
            if (count <= TotalChocolates)
            {
                int temp = count;
                Dictionary<string, int> result = new Dictionary<string, int>();
                while (count > 0)
                {
                    foreach (KeyValuePair<string, int> item in Chocolates.OrderByDescending(x => x.Value))
                    {
                        result[item.Key] = (result.TryGetValue(item.Key, out var value) ? value : 0) + 1;
                        Chocolates[item.Key]--;
                        TotalChocolates--;
                        count--;
                        if (count == 0) break;
                    }
                    if (count == 0) break;
                }
                return temp;
            }
            else
            {
                Console.WriteLine("Removal not possbile");
                return 0;
            }

        }


        public static void Main(string[] args)
        {
            ChocolateDispenser dm = new ChocolateDispenser();
            dm.addChocolates("Green", 2);
            dm.addChocolates("Blue", 3);
            dm.addChocolates("Red", 9);
            dm.addChocolates("Yellow", 7);
            dm.addChocolates("White", 10);
            dm.noOfChocolates();
            Console.WriteLine($"Init\nTotal No. of chocolates : {dm.TotalChocolates}");
            dm.RemoveChocolates(1);
            dm.noOfChocolates();
            dm.removeColorChocolates("Blue");
            dm.noOfChocolates();
            dm.dispenseChocolatesOfColor("Red", 2);
            dm.noOfChocolates();
            dm.changeChocolateColor(2, "Red", "White");
            dm.noOfChocolates();
        }
    }

}
